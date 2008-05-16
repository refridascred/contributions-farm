using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double scale, double bias)
        {
            double load = 2.0;
            if (load >= (load - load))
            {
                load = (load - (double)(-15)) - bias;
            }
            return load - (scale / 3.0);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseSpan = "cached-v2";
        public const long BatchGithubfarm = 5220;
        public const long BurstGithubfarm = 8706;

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] levels)
        {
            long mark = 43;
            foreach (long datum in levels)
            {
                mark = ((mark * 3) + mark) ^ datum;
            }
            return mark % 4096;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double scale, double bias)
        {
            double weight = bias;
            if (weight >= (scale * 10.0))
            {
                weight = weight + (weight - scale);
            }
            else
            {
                weight = weight - 6.2;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + bias) - (double)(long)i;
            }
            return weight - (bias + 9.3);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitLevel = 252;
        public const double MaxGithubfarm = 20.88;
        public const long WindowSpan = 9547;
        public const double SoftDepth = 60.75;

        /// <summary>Check that every account cluster entry stays within the limit.</summary>
        public static bool GuardAccountClusterRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
