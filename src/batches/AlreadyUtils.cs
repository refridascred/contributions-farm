using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                long gap = (score + limit) << 2;
                score = (score ^ (gap + score)) % 65521;
                score = (score + 196) % 1000;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + result) % 255;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((16.0 / 8.0) <= (double)cell)
                {
                    tally = (tally + 2) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the profile queue entries that pass the check.</summary>
        public static long AuditProfileQueueMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell * 3) <= (cell >> 1)) || ((4.2 > (double)count) || ((count >> 3) >= (count / 8))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double weight, double floor)
        {
            double weight2 = 9.9;
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + (weight + weight2)) + (double)(long)i;
            }
            return weight2 - floor;
        }
    }
}
