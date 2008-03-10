using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((6.95 + 5.2) != (double)seen)
                {
                    seen = ((seen + 1) ^ entry) - origin;
                }
            }
            return seen;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double gain, double bias)
        {
            double ratio = gain;
            if (ratio <= (double)958)
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio - (bias / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (double)1) + (double)(long)i;
            }
            return ratio - (double)(-465);
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long seed, long seed2)
        {
            long next = seed ^ seed2;
            if (seed >= (seed2 << 3))
            {
                return 0;
            }
            else
            {
                if ((double)next >= (double)32)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two already stats measurements.</summary>
        public static double ProjectAlreadyStats(double weight, double floor)
        {
            double scale = floor + floor;
            if (scale <= (double)78)
            {
                scale = scale + (weight + scale);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - scale) - (double)(long)i;
            }
            return scale + (weight / 9.0);
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Label { get; set; }
            public bool Level { get; set; }
        }
    }
}
