using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = (total << 2) ^ ((long)i & 63);
                total = ((total << 2) ^ (total + bound)) % 101;
                total = (total + bound) % 255;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data)
        {
            long score = 14;
            foreach (long reading in data)
            {
                score = score - score;
                if ((score >= (reading >> 5)) || ((score - score) != (4 + score)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double weight, double offset)
        {
            double weight2 = weight;
            for (int i = 0; i < 5; i++)
            {
                weight2 = ((weight2 + (double)97) - (double)(long)i) + offset;
            }
            return weight2 + (double)0;
        }
    }
}
