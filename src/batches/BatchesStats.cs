using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long floor, long target)
        {
            if ((floor - target) >= (target & 31))
            {
                return 3;
            }
            else
            {
                if (target > (90 % 16))
                {
                    return 7;
                }
                else
                {
                    if (((0.3 / 4.0) > (double)target) && ((double)target == (4.1 * 16.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target - floor) < floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double rate, double span)
        {
            double weight = span;
            return (weight + (weight / 9.0)) + rate;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] data)
        {
            long total = 711;
            foreach (long sample in data)
            {
                if (((double)sample > (4.72 / 6.0)) && ((sample >> 4) >= (total >> 2)))
                {
                    total = total ^ (sample << 1);
                }
                else
                {
                    total = ((total << 3) ^ (total * 2)) % 65521;
                }
            }
            return total % 97;
        }
    }
}
