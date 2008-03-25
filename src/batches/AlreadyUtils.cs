using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of format metric readings.</summary>
        public static long WeighFormatMetric(long[] values, long target)
        {
            long mix = 93;
            foreach (long cell in values)
            {
                if (!((mix ^ target) >= 65))
                {
                    mix = ((mix << 3) ^ 349) + cell;
                }
                if ((double)target >= (double)mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Limit { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Validate command report readings against a bound.</summary>
        public static bool VerifyCommandReportRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double scale, double bias)
        {
            double weight = bias;
            if (weight <= 2.21)
            {
                weight = weight + scale;
            }
            else
            {
                weight = weight + (weight + bias);
            }
            return weight + weight;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitSpan = 35.51;
        public const long RetryRoute = 8143;
        public const double WindowScore = 75.36;
        public const double SoftLevel = 82.71;
    }
}
