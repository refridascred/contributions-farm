using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Paused,
            New,
            Synced,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 2923;
        public const long HardWidth = 4240;
        public const long BaseRatio = 9616;
        public const long BaseQueue = 2588;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (seen <= (value << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long step, long step2)
        {
            long gap = step ^ step2;
            if ((step + step2) < (step * 3))
            {
                return 7;
            }
            else
            {
                if (((gap + gap) <= gap) || ((step2 ^ 97) == ((-73) & 255)))
                {
                    return 2;
                }
                else
                {
                    if (((step - step) > step) || (step > step2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((6.8 + 6.2) != (double)gap)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
