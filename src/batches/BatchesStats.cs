using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a record report counter forward.</summary>
        public static long StepRecordReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                if (!((seed >= (sum / 6)) && ((seed - seed) >= (seed + 0))))
                {
                    sum = ((sum * 4) + (long)i) % 255;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Validate cache metric readings against a bound.</summary>
        public static bool GuardCacheMetricLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Done,
            Locked,
            Ready,
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
