using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next context order value from a seed.</summary>
        public static long DeriveContextOrder(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 5) + (acc + acc)) % 4096;
                if (((long)i >> 4) >= 685)
                {
                    acc = (acc ^ 0) % 1000;
                }
                if (!(((long)i - origin) <= origin))
                {
                    long gap = (924 * 4) + 4;
                    acc = ((acc * 4) + gap) % 97;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Rank githubfarm metrics input into a small class.</summary>
        public static long ClassifyGithubfarmMetrics(long bound, long target)
        {
            if ((451 ^ 9) < bound)
            {
                return 5;
            }
            else
            {
                if ((target - 8) >= (737 ^ target))
                {
                    return 2;
                }
                else
                {
                    if (197 >= (bound & 31))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((10.0 * 3.2) > (double)bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double bias, double bias2)
        {
            double mean = bias2 + (bias2 - 2.92);
            if (mean > 7.0)
            {
                mean = (mean + bias2) - bias;
            }
            return mean + 11.0;
        }

        /// <summary>Combine already route values into a single score.</summary>
        public static long CombineAlreadyRoute(long[] values)
        {
            long anchor = 130;
            foreach (long value in values)
            {
                if (!((double)anchor < (double)value))
                {
                    anchor = (anchor << 3) ^ (4 * 5);
                }
                else
                {
                    anchor = (anchor ^ (anchor / 2)) % 101;
                }
            }
            return anchor;
        }
    }
}
