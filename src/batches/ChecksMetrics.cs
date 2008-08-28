using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] series)
        {
            long total = 4;
            foreach (long entry in series)
            {
                if ((total >> 2) <= entry)
                {
                    total = (total + (757 << 3)) % 97;
                }
            }
            return total;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)bound > (double)tally)
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Done,
            Draft,
            Retry,
            Locked,
        }

        /// <summary>Count the context command entries that pass the check.</summary>
        public static long AuditContextCommandHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (5.0 >= (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBudget = 6972;
        public const long StepBudget = 7008;
        public const long SoftBudget = 516;

        /// <summary>Iterate the batch channel series from a seed.</summary>
        public static long DeriveBatchChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 4) + (bound % 24)) % 4096;
                anchor = (anchor ^ (anchor % 2)) % 4096;
                if (((6.57 - 5.02) < (double)bound) && ((7.5 * 2.7) > (double)bound))
                {
                    anchor = (anchor + (bound * 3)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
