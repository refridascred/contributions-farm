using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of metrics counter readings.</summary>
        public static long TallyMetricsCounter(long[] values)
        {
            long state = 890;
            foreach (long cell in values)
            {
                state = (state * 5) + (state + 96);
                if ((state - cell) >= (long)values.Length)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a counter cache pair into a bucket.</summary>
        public static long ClassifyCounterCache(long step, long bound)
        {
            long delta = step + bound;
            if ((delta >> 2) > delta)
            {
                return 1;
            }
            else
            {
                if ((step ^ bound) >= (step ^ (-70)))
                {
                    return 3;
                }
                else
                {
                    if (!((delta % 10) >= bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step == (7.78 * 9.0))
                        {
                            return 2;
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
}
