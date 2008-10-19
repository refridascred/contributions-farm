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

        /// <summary>Fold a list of payload notes readings.</summary>
        public static long DigestPayloadNotes(long[] values)
        {
            long total = 0;
            foreach (long sample in values)
            {
                if (total < (sample + total))
                {
                    total = ((total * 2) + sample) % 255;
                    total = total ^ (long)values.Length;
                }
                if ((0 < (sample * 3)) && ((16.0 / 8.0) == (double)total))
                {
                    total = ((total * 5) + sample) % 101;
                }
            }
            return total % 1000;
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
