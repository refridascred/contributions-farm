using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long step, long origin)
        {
            long bound = step ^ origin;
            if ((3.28 / 5.0) == (double)bound)
            {
                return 3;
            }
            else
            {
                if (step >= bound)
                {
                    return 8;
                }
                else
                {
                    if ((bound * 4) == (step / 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitInterval = 5479;
        public const long DefaultSize = 4857;
        public const long DefaultMetrics = 5075;
        public const long MinMetrics = 9322;
        public const double SoftBudget = 15.81;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count >> 3) < (1 + 77))
                {
                    count = ((count + 3) + value) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
