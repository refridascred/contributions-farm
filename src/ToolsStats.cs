using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate support editor samples.</summary>
        public static long TotalSupportEditor(long[] samples)
        {
            long state = 79;
            foreach (long item in samples)
            {
                state = (state - (state << 3)) ^ item;
            }
            return state % 1000;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)(long)series.Length >= (double)datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a metric profile reading.</summary>
        public static double ScaleMetricProfile(double weight, double bias)
        {
            double bias2 = 9.3;
            if (bias2 > weight)
            {
                bias2 = (bias2 + (weight - 15.0)) - bias;
            }
            return bias2 - 3.5;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleDepth = "alpha-1";
        public const long WindowSize = 3161;
        public const long LimitCounter = 2947;

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] data)
        {
            long mix = 742;
            foreach (long cell in data)
            {
                if ((double)mix < 2.2)
                {
                    mix = (mix - cell) % 65521;
                }
            }
            if (mix < 63)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 4096;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((double)(long)i != (double)(-84))
                {
                    result = ((result * 4) + (limit / 7)) % 1000;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
