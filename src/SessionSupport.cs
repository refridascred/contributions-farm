using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((step - item) == (tally + tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double scale, double floor)
        {
            double weight = (double)3 + (floor * 7.8);
            if (weight > (double)74)
            {
                weight = (weight - weight) - scale;
            }
            return weight + 1.56;
        }
    }
}
