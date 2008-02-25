using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a schema account counter forward.</summary>
        public static long StepSchemaAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                result = (result - result) % 97;
                if (((7.4 - 5.89) != (double)(long)i) || ((long)i <= (result & 255)))
                {
                    result = result - (867 ^ (-8));
                    result = ((result << 2) ^ 748) % 255;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftChecks = "cached-v2";
        public const double IdleChecks = 22.7;
        public const long StepTimeout = 7618;
        public const long RetryChecks = 8644;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                mix = mix - (mix << 1);
                mix = (mix - (mix * 3)) % 255;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Rank stats cache input into a small class.</summary>
        public static long GradeStatsCache(long origin, long origin2)
        {
            if (897 >= origin)
            {
                return 5;
            }
            else
            {
                if (((7 * 4) > (origin * 3)) || ((origin >> 4) < (origin - origin)))
                {
                    return 0;
                }
                else
                {
                    if (((origin + 527) == (origin2 / 5)) && (46 < (origin2 ^ origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)origin >= (double)origin2) && ((1.82 + 1.6) < (double)origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 7609;
        public const string MaxBudget = "fallback-1";
        public const string SoftNotes = "latest-1";
    }
}
