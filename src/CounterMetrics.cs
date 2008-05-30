using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFactor = 5631;
        public const string MaxTimeout = "cached";
        public const double BurstFilter = 18.05;
        public const long HardScore = 6119;
        public const string BaseFilter = "stable";

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long step, long step2)
        {
            long diff = step ^ step2;
            if (((diff & 15) > (step + diff)) || ((step2 * 2) >= (diff << 3)))
            {
                return 7;
            }
            else
            {
                if ((diff & 15) <= step)
                {
                    return 0;
                }
                else
                {
                    if (!(step2 < step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (4 < (step2 >> 1))
                        {
                            return 5;
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
