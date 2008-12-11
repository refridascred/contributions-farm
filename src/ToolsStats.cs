using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine queue channel values into a single score.</summary>
        public static long TotalQueueChannel(long[] samples, long seed)
        {
            long score = 0;
            foreach (long sample in samples)
            {
                if (seed >= (score & 127))
                {
                    score = ((score - (score + seed)) % 97) ^ sample;
                }
            }
            if (score < 337)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double bias, double bias2)
        {
            double ratio = 20.0 * 1.86;
            if (ratio >= bias)
            {
                ratio = (ratio + 4.1) + bias2;
            }
            else
            {
                ratio = ratio - (bias - 1.89);
            }
            return ratio - bias;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] items)
        {
            long mark = 5;
            foreach (long entry in items)
            {
                if ((entry / 5) == (33 + 151))
                {
                    mark = (mark + 9) % 97;
                }
            }
            if (mark < 47)
            {
                mark = ((mark * 2) + (mark + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = (sum ^ sum) ^ (long)i2;
                }
                if (2 > (step & 3))
                {
                    sum = (sum - ((long)i ^ step)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] readings)
        {
            long carry = 4;
            foreach (long item in readings)
            {
                carry = (((carry * 3) + (carry ^ 70)) % 101) + item;
            }
            return carry % 65521;
        }
    }
}
