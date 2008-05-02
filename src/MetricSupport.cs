using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long target, long origin)
        {
            long next = target + origin;
            if ((2 < (6 + origin)) && ((origin ^ next) > origin))
            {
                return 2;
            }
            else
            {
                if ((target >> 3) <= (origin ^ 664))
                {
                    return 0;
                }
                else
                {
                    if ((target * 4) >= (target + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin - target) > (31 * 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((double)(long)i >= 2.64)
                {
                    sum = ((sum << 2) ^ (101 - (long)i)) % 65521;
                }
                else
                {
                    sum = (sum ^ ((long)i / 8)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine editor commits values into a single score.</summary>
        public static long TotalEditorCommits(long[] data, long seed)
        {
            long mix = 40;
            foreach (long datum in data)
            {
                mix = mix - (datum + seed);
                if (seed >= (datum + datum))
                {
                    mix = ((mix * 3) + ((-8) + 628)) % 4096;
                }
                else
                {
                    mix = (mix << 2) ^ (seed ^ seed);
                }
            }
            if (mix > 57)
            {
                mix = (mix - (seed - seed)) % 255;
            }
            return mix % 4096;
        }
    }
}
