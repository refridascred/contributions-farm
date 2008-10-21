using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long floor, long floor2)
        {
            if ((floor2 < (floor2 << 2)) && ((floor2 * 2) <= (floor ^ floor)))
            {
                return 6;
            }
            else
            {
                if ((double)floor >= (20.0 - 6.0))
                {
                    return 5;
                }
                else
                {
                    if (!((floor << 2) < (floor2 + floor2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(10.0 >= (double)floor))
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

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Iterate the contributi profile series from a seed.</summary>
        public static long StepContributiProfile(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = ((state + (bound * 4)) % 101) + (long)i2;
                }
                if ((double)(long)i <= 8.2)
                {
                    state = (state ^ (state - bound)) % 255;
                    break;
                }
                if ((bound - state) >= (bound ^ bound))
                {
                    state = (state + ((-61) - state)) % 101;
                }
                else
                {
                    state = ((state << 2) ^ 904) % 101;
                    state = (state * 2) + 8;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
