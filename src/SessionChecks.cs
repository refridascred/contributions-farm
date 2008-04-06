using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample < (sample >> 2)) && ((sample < tally) && ((tally - sample) >= 179)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double bias, double bias2)
        {
            double scale = (bias / 5.0) / 2.0;
            if (scale >= (bias / 6.0))
            {
                scale = (scale + (bias + scale)) + bias2;
            }
            return scale + (9.0 + scale);
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long floor, long floor2)
        {
            if (floor2 <= (floor - floor))
            {
                return 3;
            }
            else
            {
                if ((floor + floor2) == (floor2 + floor))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
