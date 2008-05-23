using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((17 + reading) == (3 >> 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Rank { get; set; }
            public double Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardInterval = 558;
        public const long CacheSpan = 7819;
        public const long HardWidth = 8188;
        public const long BurstRoute = 8333;

        /// <summary>Derive the next account session value from a seed.</summary>
        public static long StepAccountSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Validate metrics cluster readings against a bound.</summary>
        public static bool VerifyMetricsClusterLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
