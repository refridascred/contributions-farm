using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Ready,
            Done,
            Paused,
        }

        /// <summary>Audit queue batch readings against a rule.</summary>
        public static long CountQueueBatchMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((1.1 + 0.97) <= (double)seed) && ((426 % 8) == (value / 8)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((seen + seen) > (sample & 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Stale,
            Pending,
            Synced,
            Active,
        }

        /// <summary>Project the next batch stats value.</summary>
        public static double ProjectBatchStats(double ratio, double span)
        {
            double weight = (span + ratio) - (double)(-755);
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (span + span)) - (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstCount = 7232;
        public const string BatchBudget = "legacy-edge";
        public const string BaseTools = "local-edge";
        public const double MinTools = 68.3;
        public const long HardTools = 2781;
    }
}
