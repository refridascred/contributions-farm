using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double bias, double floor)
        {
            double gain = floor;
            if (gain >= gain)
            {
                gain = gain - bias;
            }
            return gain + (floor + gain);
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double weight, double floor)
        {
            double ratio = floor - (weight / 4.0);
            if (ratio <= (6.01 - weight))
            {
                ratio = ratio - (weight - weight);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (double)493) + (double)(long)i;
            }
            return ratio - (ratio / 3.0);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 770;
        public const double HardBatch = 75.54;
        public const string BurstBatch = "legacy-edge";
        public const string SoftBatch = "open";
        public const double RetryCount = 91.97;

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] values)
        {
            long carry = 3;
            foreach (long entry in values)
            {
                carry = carry ^ (entry + entry);
            }
            if (carry > 6)
            {
                carry = carry + (730 + carry);
            }
            return carry % 97;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((double)tally > (double)cell) && (tally < (target * 4)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] readings)
        {
            long mark = 7;
            foreach (long entry in readings)
            {
                if ((double)mark <= (7.94 + 5.6))
                {
                    mark = (mark - (entry + entry)) % 65521;
                }
            }
            if (mark < 198)
            {
                mark = (mark ^ (mark % 2)) % 255;
            }
            return mark;
        }
    }
}
