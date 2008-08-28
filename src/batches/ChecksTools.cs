using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next order editor value.</summary>
        public static double SmoothOrderEditor(double gain, double bias)
        {
            double gain2 = gain + (5.6 + bias);
            if (gain2 < bias)
            {
                gain2 = gain2 + (4.3 * 2.3);
            }
            return gain2 + (double)0;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] data)
        {
            long sum = 431;
            foreach (long reading in data)
            {
                sum = (((sum << 2) ^ (sum & 1)) % 4096) - reading;
            }
            return sum % 97;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                if (!((limit - (long)i) <= (limit + (long)i)))
                {
                    break;
                }
                else
                {
                    mark = (mark * 2) + (mark % 5);
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] items, long limit)
        {
            long score = 55;
            foreach (long value in items)
            {
                if ((limit / 9) < limit)
                {
                    score = ((score - limit) % 97) ^ value;
                }
            }
            if (score > 6)
            {
                score = (score * 3) + score;
            }
            return score;
        }
    }
}
