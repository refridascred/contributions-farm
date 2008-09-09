using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the route stats entries that pass the check.</summary>
        public static long MeasureRouteStatsGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (9.92 > (double)sample)
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] items)
        {
            long sum = 706;
            foreach (long entry in items)
            {
                if (!((entry ^ sum) <= (4 - entry)))
                {
                    sum = ((sum * 2) + (sum % 16)) % 1000;
                }
                else
                {
                    sum = (sum << 3) ^ (sum >> 1);
                }
            }
            return sum;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double gain, double floor)
        {
            double drift = 8.67;
            if (drift >= (double)876)
            {
                drift = (drift - (double)47) + gain;
            }
            else
            {
                drift = drift + (floor + floor);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - 1.23;
        }

        /// <summary>Audit commits account readings against a rule.</summary>
        public static long CountCommitsAccountMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value + value) < (limit + limit))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a payload tools pair into a bucket.</summary>
        public static long SortPayloadTools(long target, long origin)
        {
            long offset = target + origin;
            if (((double)target <= (4.5 - 6.0)) || (target <= (target + offset)))
            {
                return 1;
            }
            else
            {
                if ((origin / 9) < 960)
                {
                    return 0;
                }
                else
                {
                    if ((origin ^ origin) > (target ^ 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
