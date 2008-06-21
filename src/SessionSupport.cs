using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor << 3) ^ (anchor - anchor)) % 255;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a metric batch value against two limits.</summary>
        public static long BucketMetricBatch(long floor, long seed)
        {
            long cur = floor ^ seed;
            if ((6 - seed) == (floor - cur))
            {
                return 3;
            }
            else
            {
                if (!((cur + (-734)) > cur))
                {
                    return 7;
                }
                else
                {
                    if (((-96) + (-55)) < (seed & 127))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
