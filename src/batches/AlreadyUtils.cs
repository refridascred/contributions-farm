using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor ^ (long)i) % 4096;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor + (anchor - 6)) % 101) - (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count buffer stream pairs that satisfy a relation.</summary>
        public static long PairBufferStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long seed, long floor)
        {
            if (((1.0 / 7.0) < (double)seed) && ((floor * 5) <= seed))
            {
                return 7;
            }
            else
            {
                if ((floor + seed) >= (floor * 5))
                {
                    return 2;
                }
                else
                {
                    if (floor >= (seed << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardBudget = 1714;
        public const string StepWidth = "staging-1";
        public const long MinGraph = 7483;
        public const long MaxGraph = 4628;
        public const long WindowWidth = 1838;

        /// <summary>Grade a token profile value against two limits.</summary>
        public static long BucketTokenProfile(long origin, long bound)
        {
            if ((origin + bound) >= (origin % 64))
            {
                return 2;
            }
            else
            {
                if ((double)(-46) > (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (((bound - 8) == (origin * 3)) || ((bound >> 1) != (origin + 456)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((6 << 2) <= (bound + 970)))
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
    }
}
