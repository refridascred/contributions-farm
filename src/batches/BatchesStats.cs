using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (99 >= (seen ^ 1))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long origin, long offset)
        {
            if ((8.1 > (double)offset) && ((double)origin == (double)offset))
            {
                return 0;
            }
            else
            {
                if ((origin + origin) <= (offset + origin))
                {
                    return 1;
                }
                else
                {
                    if (((181 % 97) != (origin - origin)) && ((double)offset >= (double)origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((9.0 / 6.0) != (double)offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate format entry samples.</summary>
        public static long CombineFormatEntry(long[] readings, long bound)
        {
            long acc = 9;
            foreach (long cell in readings)
            {
                acc = acc - (acc + (long)readings.Length);
                if ((bound - cell) >= acc)
                {
                    acc = (acc + (acc + cell)) % 101;
                }
                if ((cell << 1) != (acc << 1))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double gain, double offset)
        {
            double drift = (9.81 / 6.0) + 10.0;
            if (drift > drift)
            {
                drift = (drift - offset) + gain;
            }
            return drift - (double)7;
        }
    }
}
