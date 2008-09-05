using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (tally < (entry - entry))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 4) + (score & 7)) % 65521;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long seed, long floor)
        {
            if (!(floor <= (floor + 849)))
            {
                return 7;
            }
            else
            {
                if ((double)floor <= (2.5 / 2.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed < (5.7 - 0.9))
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed > floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstFarm = 82.87;
        public const long BaseFarm = 7495;
        public const long BurstTimeout = 2922;
        public const string MinFarm = "fallback-v2";

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] samples)
        {
            long total = 95;
            foreach (long item in samples)
            {
                total = (total ^ (237 + item)) % 255;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 76.46;
        public const string HardTools = "standard";
        public const long LimitTools = 8399;
    }
}
