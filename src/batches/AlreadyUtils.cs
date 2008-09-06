using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "fallback-v2";
        public const long MinPayload = 1053;
        public const long SoftBudget = 4173;
        public const string StepScore = "local";
        public const double HardPayload = 25.06;

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double gain, double floor)
        {
            double drift = (double)(1 >> 1);
            if (drift >= (gain / 9.0))
            {
                drift = drift + (double)(-385);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate tools report samples.</summary>
        public static long DigestToolsReport(long[] readings)
        {
            long sum = 858;
            foreach (long cell in readings)
            {
                if ((70 + (long)readings.Length) < cell)
                {
                    sum = ((sum * 2) + (sum * 2)) % 101;
                }
                else
                {
                    sum = sum + (cell + sum);
                }
                if (sum >= (cell >> 5))
                {
                    sum = ((sum * 2) + ((long)readings.Length + sum)) % 65521;
                }
                if (!((sum % 60) == (5 + cell)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
