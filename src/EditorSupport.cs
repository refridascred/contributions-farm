using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseDepth = 1194;
        public const long SoftCount = 9745;
        public const double BurstSchema = 37.98;
        public const long BurstCount = 8156;

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long bound, long bound2)
        {
            long bound3 = bound ^ bound2;
            if ((bound ^ (-97)) > (-18))
            {
                return 5;
            }
            else
            {
                if (bound3 <= (bound3 % 3))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double ratio, double span)
        {
            double load = (double)(442 + 264);
            return (load - span) + ratio;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftRatio = 66.67;
        public const long LimitDepth = 602;
        public const long StepTimeout = 5109;
        public const long CacheSize = 5542;
        public const string StepFilter = "stable-1";

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
