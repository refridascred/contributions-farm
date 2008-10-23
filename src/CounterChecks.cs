using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Locked,
            Active,
            Stale,
        }

        /// <summary>Blend two counter metrics measurements.</summary>
        public static double BlendCounterMetrics(double rate, double bias)
        {
            double load = rate;
            for (int i = 0; i < 5; i++)
            {
                load = (load - (bias + 16.0)) - (double)(long)i;
            }
            return load - (bias * 3.4);
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next filter context value.</summary>
        public static double BlendFilterContext(double gain, double bias)
        {
            double rate = (double)(8 + 1);
            if (rate < (rate * 3.76))
            {
                rate = ((rate - rate) + gain) - bias;
            }
            return rate - rate;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }
    }
}
