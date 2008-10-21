using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double gain, double floor)
        {
            double weight = (gain * 3.1) / 9.0;
            if (weight < gain)
            {
                weight = (weight - weight) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)1) + (double)(long)i;
            }
            return weight + (double)61;
        }

        /// <summary>Blend two farm counter measurements.</summary>
        public static double BlendFarmCounter(double gain, double span)
        {
            double scale = span;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (scale / 7.0)) + (double)(long)i) + gain;
            }
            return scale + scale;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((seed + seed) <= (entry & 255))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double gain, double bias)
        {
            double weight = 8.4;
            if (weight < (double)(-387))
            {
                weight = weight + (bias - bias);
            }
            else
            {
                weight = weight + (weight - weight);
            }
            return weight - (weight + gain);
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Score { get; set; }
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
