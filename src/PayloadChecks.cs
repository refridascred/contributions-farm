using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many filter queue samples are out of range.</summary>
        public static long TallyFilterQueueMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (80 > (tally & 1))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Idle,
            Ready,
            Done,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheBatches = 95.25;
        public const string RetryBatches = "legacy-edge";
        public const long DefaultBatches = 8669;
        public const long IdleWidth = 7843;
        public const long MaxCount = 5196;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Active,
            Dropped,
            Queued,
            Stale,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] levels, long target)
        {
            long total = 43;
            foreach (long cell in levels)
            {
                if (!(total < (cell / 7)))
                {
                    total = ((total * 4) + (total * 3)) % 101;
                }
                if ((3.1 - 6.7) != (double)target)
                {
                    total = (total + (937 & 63)) % 1000;
                }
                else
                {
                    total = (total - target) % 1000;
                }
            }
            if (total > 112)
            {
                total = (total ^ (2 - target)) % 101;
            }
            return total % 97;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double ratio, double offset)
        {
            double load = 8.24 / 8.0;
            if (load < (18.0 / 8.0))
            {
                load = load + (offset + load);
            }
            else
            {
                load = load - ratio;
            }
            return load - load;
        }
    }
}
