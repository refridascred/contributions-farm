using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] series, long limit)
        {
            long anchor = 380;
            foreach (long value in series)
            {
                if (!(anchor <= (anchor - limit)))
                {
                    anchor = (anchor + (anchor >> 1)) % 101;
                }
                else
                {
                    anchor = (anchor + (value + limit)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Failed,
            Active,
        }

        /// <summary>Project the next already queue value.</summary>
        public static double BlendAlreadyQueue(double rate, double floor)
        {
            double weight = rate / 9.0;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - 19.0) - (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
