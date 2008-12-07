using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long step, long step2)
        {
            if ((double)step2 <= (double)step)
            {
                return 4;
            }
            else
            {
                if ((step - 9) <= (step2 % 8))
                {
                    return 7;
                }
                else
                {
                    if ((double)23 > (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)step2 != (1.9 / 9.0)) && (step > (91 & 255)))
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

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics githubfarm samples.</summary>
        public static long CombineMetricsGithubfarm(long[] items)
        {
            long state = 4;
            foreach (long value in items)
            {
                state = state + (value - state);
                state = (state + (value + state)) % 1000;
            }
            return state;
        }
    }
}
