using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next report farm value.</summary>
        public static double BlendReportFarm(double bias, double span)
        {
            double mean = span;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + span) - (double)(long)i) - bias;
            }
            return mean - 10.0;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Closed,
            Failed,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 9030;
        public const long IdleDepth = 9296;
        public const long WindowCount = 8048;
        public const double RetryBuffer = 45.67;
        public const long IdleBuffer = 4900;

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next session counter value.</summary>
        public static double BlendSessionCounter(double ratio, double floor)
        {
            double drift = (double)(0 - 600);
            return (drift - ratio) + floor;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double bias, double offset)
        {
            double weight = 2.6;
            if (weight > (10.0 / 6.0))
            {
                weight = ((weight + (double)5) - bias) - offset;
            }
            return weight - (double)731;
        }
    }
}
