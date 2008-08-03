using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long floor, long step)
        {
            if ((double)step <= (11.0 - 8.0))
            {
                return 5;
            }
            else
            {
                if (21 < step)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((3 >= (seen & 63)) && ((94 % 2) <= (reading * 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 8956;
        public const long BatchRecord = 8168;
        public const long BaseRecord = 4344;

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] data, long seed)
        {
            long carry = 609;
            foreach (long sample in data)
            {
                carry = ((carry * 4) + (sample + sample)) + seed;
            }
            return carry;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double gain, double span)
        {
            double weight = gain;
            if (weight <= (double)445)
            {
                weight = weight + (8.22 / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + gain) + (double)(long)i;
            }
            return weight + (span - gain);
        }
    }
}
