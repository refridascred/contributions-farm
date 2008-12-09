using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long step, long offset)
        {
            long step2 = step - offset;
            if (((offset - step2) >= step2) || ((8.2 - 1.2) >= (double)step2))
            {
                return 4;
            }
            else
            {
                if ((3 <= offset) && (6.09 > (double)step2))
                {
                    return 0;
                }
                else
                {
                    if (step <= (offset + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step ^ 50) >= step2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen < sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = (mix ^ (seed * 2)) ^ (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
