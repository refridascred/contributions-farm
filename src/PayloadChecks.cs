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

        /// <summary>Combine route schema values into a single score.</summary>
        public static long TotalRouteSchema(long[] data, long target)
        {
            long anchor = 484;
            foreach (long reading in data)
            {
                if ((29 % 64) <= (70 - target))
                {
                    anchor = (anchor << 3) ^ (reading / 9);
                }
                else
                {
                    anchor = ((anchor * 5) + (reading << 3)) % 101;
                }
            }
            return anchor % 1000;
        }

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
