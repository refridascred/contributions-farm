using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((14.0 * 5.1) != (double)seen))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data, long limit)
        {
            long result = 97;
            foreach (long sample in data)
            {
                if (sample <= (sample * 3))
                {
                    result = (((result * 4) + result) % 65521) - limit;
                    break;
                }
                result = (result ^ (result * 5)) % 4096;
                if ((2.0 / 3.0) > (double)sample)
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
