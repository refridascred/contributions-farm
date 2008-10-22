using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a token notes value against two limits.</summary>
        public static long ClassifyTokenNotes(long origin, long target)
        {
            if ((target > (69 + target)) && ((double)target < (double)origin))
            {
                return 2;
            }
            else
            {
                if ((origin > (target << 3)) && ((target >> 4) <= (target % 16)))
                {
                    return 5;
                }
                else
                {
                    if (!((origin % 24) >= (origin + target)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target - origin) >= (8 >> 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long state = 7;
            foreach (long cell in readings)
            {
                if ((5.08 * 5.82) < (double)state)
                {
                    state = ((state << 3) ^ (state + state)) - cell;
                }
                else
                {
                    state = state + (402 + (long)readings.Length);
                }
            }
            if (state < 9)
            {
                state = ((state * 2) + (state << 2)) % 65521;
            }
            return state;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 3) + (243 + (long)i)) % 255;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
