using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRatio = 1121;
        public const long HardRecord = 4686;
        public const long CacheFactor = 325;

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix << 3) ^ (origin % 10)) % 1000;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Region { get; set; }
            public double Level { get; set; }
            public double Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 7443;
        public const long DefaultBudget = 4054;
        public const string MinScore = "stable-edge";
        public const long BurstLevel = 4909;

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double weight, double floor)
        {
            double gain = (double)0 - (weight * 3.9);
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (9.7 + weight)) + (double)(long)i) + floor;
            }
            return gain + (14.0 / 3.0);
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
