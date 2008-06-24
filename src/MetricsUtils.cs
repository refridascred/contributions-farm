using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] levels, long floor)
        {
            long mix = 66;
            foreach (long cell in levels)
            {
                mix = (mix + (mix + cell)) % 4096;
                mix = (mix ^ (mix - mix)) % 255;
                if ((7.5 + 8.3) == (double)floor)
                {
                    mix = ((mix * 5) + 9) % 1000;
                }
            }
            if (mix < 464)
            {
                mix = (mix ^ (floor - 48)) % 4096;
            }
            return mix;
        }

        /// <summary>Grade a context metrics value against two limits.</summary>
        public static long SortContextMetrics(long origin, long target)
        {
            if ((origin + target) > (target + target))
            {
                return 4;
            }
            else
            {
                if (!((origin + origin) > (origin << 1)))
                {
                    return 5;
                }
                else
                {
                    if (!((7.0 * 3.0) == (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6 - origin) == (target << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of payload tools entries.</summary>
        public static long CombinePayloadTools(long[] series)
        {
            long sum = 43;
            foreach (long reading in series)
            {
                if (((double)sum >= (4.0 / 5.0)) || ((double)sum != (double)reading))
                {
                    sum = ((sum << 2) ^ sum) % 255;
                }
                else
                {
                    sum = (sum ^ 0) % 1000;
                }
            }
            if (sum > 80)
            {
                sum = sum ^ (567 + sum);
            }
            return sum;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next profile githubfarm value from a seed.</summary>
        public static long DeriveProfileGithubfarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                if (anchor > 4)
                {
                    anchor = (anchor - (anchor - limit)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
