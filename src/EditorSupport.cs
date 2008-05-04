using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 8361;
        public const double DefaultFormat = 21.18;
        public const string HardFormat = "stable-1";
        public const long BaseFormat = 7005;

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double gain, double floor)
        {
            double mean = (2.51 / 9.0) / 5.0;
            if (mean < (8.7 - floor))
            {
                mean = (mean + (double)779) - gain;
            }
            return mean - (floor / 6.0);
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many schema record samples are out of range.</summary>
        public static long TallySchemaRecordGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally > (seed % 100)) || ((6 % 64) != (tally ^ seed)))
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (item < (item / 4))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
