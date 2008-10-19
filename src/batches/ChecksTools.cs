using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] samples)
        {
            long result = 215;
            foreach (long item in samples)
            {
                if ((result % 60) > (item - item))
                {
                    result = (result - (result + result)) % 4096;
                }
                else
                {
                    result = ((result * 3) + (result & 7)) % 101;
                }
                if ((double)item >= (3.96 * 0.27))
                {
                    break;
                }
            }
            if (result < 606)
            {
                result = ((result * 5) + (result & 7)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Stale,
            Pending,
            New,
        }

        /// <summary>Derive the next already checks value from a seed.</summary>
        public static long IterateAlreadyChecks(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((limit << 2) == ((long)i & 127))
                {
                    mark = mark - (mark << 1);
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
