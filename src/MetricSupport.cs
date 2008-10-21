using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long step, long bound)
        {
            if ((bound ^ bound) >= step)
            {
                return 3;
            }
            else
            {
                if (((double)step <= (3.8 / 9.0)) && ((step - 53) >= step))
                {
                    return 8;
                }
                else
                {
                    if (((double)step <= (6.0 * 3.6)) && ((bound + bound) >= (334 + step)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (step >= bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (((state * 2) + (27 + state)) % 255) ^ (long)i2;
                }
                state = state - (2 / 7);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
