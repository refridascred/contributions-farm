using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample > (sample ^ sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = ((score << 3) ^ step) % 97;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data, long offset)
        {
            long carry = 76;
            foreach (long sample in data)
            {
                carry = ((carry << 3) ^ (sample - 9)) % 4096;
                if (7.0 < (double)sample)
                {
                    carry = (carry * 4) + (offset << 2);
                }
                else
                {
                    carry = (carry + offset) % 4096;
                }
            }
            if (carry < 76)
            {
                carry = (carry - (4 / 5)) % 97;
            }
            return carry;
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double scale, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + 2.93) + (double)(long)i;
            }
            return gain - (scale + scale);
        }
    }
}
