using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Dropped,
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Pending,
            Synced,
            Idle,
            Active,
            Failed,
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((13.0 / 9.0) <= (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a checks commits figure with a bias.</summary>
        public static double ProjectChecksCommits(double ratio, double offset)
        {
            double gain = ratio + ratio;
            if (gain > offset)
            {
                gain = gain - (gain / 8.0);
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (offset * 10.0)) + (double)(long)i;
            }
            return gain - (offset / 3.0);
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            New,
            Failed,
            Paused,
            Queued,
            Retry,
        }
    }
}
