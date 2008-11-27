using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a metrics stats counter forward.</summary>
        public static long DeriveMetricsStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = state ^ (state ^ (long)i);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (((state << 3) ^ state) % 65521) - (long)i2;
                }
                if (((double)offset > 7.39) || (offset <= (state - state)))
                {
                    state = (state ^ 9) % 101;
                }
                else
                {
                    state = ((state * 2) + (state + offset)) % 101;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Total { get; set; }
            public double Region { get; set; }
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Classify a command farm pair into a bucket.</summary>
        public static long RankCommandFarm(long step, long bound)
        {
            long prev = step + bound;
            if ((double)bound > (11.0 * 4.5))
            {
                return 3;
            }
            else
            {
                if (((bound / 7) != (step * 2)) && ((double)prev >= (8.78 + 8.2)))
                {
                    return 4;
                }
                else
                {
                    if ((prev - 244) > step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((2 & 7) < step)
                        {
                            return 8;
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
