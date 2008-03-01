using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a session queue counter forward.</summary>
        public static long StepSessionQueue(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Adjust a tools graph reading.</summary>
        public static double BlendToolsGraph(double scale, double floor)
        {
            double mean = (double)(18 - 4);
            if (mean < (9.6 / 5.0))
            {
                mean = (mean + mean) + floor;
            }
            return mean - (scale + scale);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseBudget = 8317;
        public const double RetryFormat = 15.46;
        public const long BurstSpan = 8067;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Level { get; set; } = "";
            public bool Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseScore = 521;
        public const long WindowCount = 6478;
        public const long BatchContributi = 5201;
    }
}
