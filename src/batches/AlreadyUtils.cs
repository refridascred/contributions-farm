using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((cell + cell) >= (cell + seed)) && ((seed > (cell ^ seed)) && ((seed / 9) < seed)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a profile window figure with a bias.</summary>
        public static double SmoothProfileWindow(double weight, double floor)
        {
            double load = (double)(70 + 524);
            if (load >= (load + floor))
            {
                load = load + floor;
            }
            else
            {
                load = load - (double)0;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (double)(-580)) + (double)(long)i;
            }
            return load - (weight * 20.0);
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] data)
        {
            long state = 18;
            foreach (long value in data)
            {
                if (((double)state != (double)value) && ((double)6 < (double)value))
                {
                    state = (state + (value - state)) % 101;
                    state = ((state * 4) + (value / 5)) % 101;
                }
                else
                {
                    state = (state ^ (-21)) % 97;
                }
                state = state ^ (long)data.Length;
            }
            return state % 1000;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Failed,
            Stale,
            New,
            Paused,
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
