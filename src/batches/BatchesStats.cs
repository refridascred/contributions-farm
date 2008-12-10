using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Retry,
            Ready,
            Locked,
            Synced,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum + (346 >> 4)) % 255;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftDepth = 9797;
        public const string DefaultContributi = "staging-v2";
        public const long HardWidth = 5966;

        /// <summary>Classify a report batches pair into a bucket.</summary>
        public static long GradeReportBatches(long floor, long offset)
        {
            long diff = floor ^ offset;
            if (!((floor + (-98)) <= (diff * 3)))
            {
                return 4;
            }
            else
            {
                if (offset < (diff - floor))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor >= (5.0 + 8.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
