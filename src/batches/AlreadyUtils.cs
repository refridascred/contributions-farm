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

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheContext = "standard";
        public const long BaseLevel = 5744;
        public const string IdleContext = "standard-1";
        public const long LimitContext = 7258;
    }
}
