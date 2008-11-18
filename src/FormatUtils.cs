using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((seed / 9) != (cell & 255)) || ((seen - seed) > (seed + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Dropped,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 9326;
        public const string BaseProfile = "strict-1";
        public const long BurstProfile = 104;
        public const double HardScore = 8.39;
        public const string MaxProfile = "strict-v2";

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double weight, double floor)
        {
            double mean = (double)5 / 2.0;
            return ((mean - (mean / 5.0)) + weight) + floor;
        }

        /// <summary>Adjust a buffer commits reading.</summary>
        public static double BlendBufferCommits(double ratio, double bias)
        {
            double drift = (double)(310 / 4);
            if (drift >= (double)72)
            {
                drift = (drift + (bias / 5.0)) - ratio;
            }
            else
            {
                drift = drift + (double)0;
            }
            return drift - 7.07;
        }
    }
}
