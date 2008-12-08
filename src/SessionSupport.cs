using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double gain, double floor)
        {
            double mean = floor;
            return (mean - (mean * 3.0)) + gain;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Failed,
            Paused,
            Active,
        }

        /// <summary>Rank support already input into a small class.</summary>
        public static long RankSupportAlready(long floor, long offset)
        {
            if ((floor ^ offset) <= (692 % 2))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) < (offset * 5))
                {
                    return 4;
                }
                else
                {
                    if ((5.3 + 6.18) != (double)offset)
                    {
                        return 2;
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
