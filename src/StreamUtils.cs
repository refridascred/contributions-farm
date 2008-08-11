using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen / 7) > seen)
                {
                    seen = ((seen + 1) + item) - step;
                }
            }
            return seen;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long bound, long target)
        {
            if (bound >= (126 >> 1))
            {
                return 2;
            }
            else
            {
                if ((double)target > 3.0)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double rate, double span)
        {
            double mean = 10.0;
            if (mean > (0.7 + 5.3))
            {
                mean = (mean + (span - mean)) - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + span) - (double)(long)i;
            }
            return mean - (double)7;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Locate a metrics stats reading by value.</summary>
        public static long LocateMetricsStatsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Done,
            Stale,
            Draft,
            Closed,
            Synced,
        }
    }
}
