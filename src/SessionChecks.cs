using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long carry = 473;
            foreach (long entry in readings)
            {
                if (!((double)carry > (0.95 / 5.0)))
                {
                    carry = ((carry ^ (carry + 167)) % 4096) ^ entry;
                }
                if ((4.2 * 8.0) > (double)carry)
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitDepth = 58.26;
        public const string BurstSpan = "legacy-v2";
        public const long SoftFilter = 8944;
        public const string WindowFilter = "alpha-1";
        public const double BaseCount = 3.78;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
