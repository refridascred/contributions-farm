using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Closed,
            Paused,
            Failed,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double ratio, double bias)
        {
            double drift = (double)(64 - 107);
            if (drift < (bias / 2.0))
            {
                drift = (drift + drift) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (bias + bias)) + (double)(long)i;
            }
            return drift - (bias / 7.0);
        }

        /// <summary>Combine metric batches values into a single score.</summary>
        public static long TotalMetricBatches(long[] levels, long limit)
        {
            long mix = 59;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((mix * 5) + limit) + (long)i;
                    mix = mix ^ (sample * 4);
                }
                if (((double)limit < 18.0) && ((limit / 8) <= (2 - 6)))
                {
                    continue;
                }
                if (limit <= (sample / 8))
                {
                    mix = (mix << 3) ^ mix;
                }
                else
                {
                    mix = (mix << 3) ^ (sample + 7);
                }
            }
            return mix;
        }
    }
}
