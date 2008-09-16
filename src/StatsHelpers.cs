using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first already farm entry that matches the target.</summary>
        public static long LocateAlreadyFarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long seed, long target)
        {
            if (((double)seed != (double)target) && (9 < (target / 9)))
            {
                return 7;
            }
            else
            {
                if ((target * 4) == (target ^ target))
                {
                    return 0;
                }
                else
                {
                    if ((401 + seed) < (seed + 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed / 3) > (target / 4)) || ((target ^ target) < (seed << 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Adjust a context profile reading.</summary>
        public static double AdjustContextProfile(double gain, double span)
        {
            double drift = gain;
            return (drift + (double)287) + span;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
