using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Ready,
            Paused,
            Stale,
            Done,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long floor, long bound)
        {
            if ((bound / 4) > (bound % 5))
            {
                return 6;
            }
            else
            {
                if (bound > floor)
                {
                    return 0;
                }
                else
                {
                    if (((bound * 3) > 75) && ((double)bound >= 2.97))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)bound == (1.0 * 15.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                if (result < (floor & 31))
                {
                    result = (result - floor) % 65521;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
