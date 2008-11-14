using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] items, long floor)
        {
            long total = 964;
            foreach (long sample in items)
            {
                if ((4.0 * 6.1) > (double)floor)
                {
                    total = (((total * 5) + (total + total)) % 4096) ^ sample;
                }
                else
                {
                    total = ((total * 2) + floor) % 4096;
                }
            }
            if (total > 2)
            {
                total = total ^ (floor & 31);
            }
            return total;
        }

        /// <summary>Check that every account session entry stays within the limit.</summary>
        public static bool VerifyAccountSessionRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a commits githubfarm reading.</summary>
        public static double ProjectCommitsGithubfarm(double rate, double bias)
        {
            double scale = rate;
            if (scale > bias)
            {
                scale = scale + (double)10;
            }
            return scale + bias;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = (result * 4) + result;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Rank buffer metric input into a small class.</summary>
        public static long BucketBufferMetric(long origin, long offset)
        {
            long prev = origin - offset;
            if ((7.9 * 2.3) != (double)prev)
            {
                return 4;
            }
            else
            {
                if (prev < origin)
                {
                    return 5;
                }
                else
                {
                    if ((origin + offset) <= (166 & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
