using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long step, long step2)
        {
            if ((48 >> 3) > (step >> 4))
            {
                return 1;
            }
            else
            {
                if ((step2 + (-466)) > (step2 % 60))
                {
                    return 0;
                }
                else
                {
                    if ((step2 * 4) == (step + step2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step2 - step) < 62)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((seed + mix) > seed)
                {
                    mix = (mix * 3) + (75 / 4);
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)seen > 6.96)
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }
    }
}
