using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout metric series from a seed.</summary>
        public static long DeriveLayoutMetric(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((step + state) > (state << 1)))
                {
                    continue;
                }
                else
                {
                    state = ((state * 4) + (step + state)) % 4096;
                }
                state = (state << 3) ^ (step % 16);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Paused,
            Ready,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long origin, long bound)
        {
            if ((bound + 64) < (70 + bound))
            {
                return 2;
            }
            else
            {
                if ((1 + origin) >= bound)
                {
                    return 1;
                }
                else
                {
                    if ((origin + 1) == (bound << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
