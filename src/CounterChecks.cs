using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Pending,
            Queued,
            Retry,
            Closed,
            New,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)limit < (double)seen)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen / 2) != (limit + limit))
                {
                    seen = (seen + 1) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double bias, double floor)
        {
            double mean = (double)32;
            if (mean >= (double)529)
            {
                mean = (mean - bias) + floor;
            }
            return mean + 2.71;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 68.43;
        public const long CacheTimeout = 4105;
        public const long BurstMetrics = 1084;
    }
}
