using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long step, long origin)
        {
            long diff = step + origin;
            if ((step % 64) == (step + 98))
            {
                return 2;
            }
            else
            {
                if (((17.0 + 6.5) > (double)origin) && ((double)origin < (1.0 / 3.0)))
                {
                    return 0;
                }
                else
                {
                    if (step < origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step / 3) == (71 / 4)) || ((double)diff >= (2.66 / 8.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up entry support samples.</summary>
        public static long OverlapEntrySupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepSize = 1548;
        public const long WindowAccount = 9375;
        public const double HardCount = 69.74;
        public const long StepBudget = 3460;

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double gain, double offset)
        {
            double load = (double)(848 >> 4);
            if (load < 6.79)
            {
                load = (load + offset) + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (double)840;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
            public bool Flag { get; set; }
        }
    }
}
