using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((5 - tally) >= (9 * 4))
                {
                    tally = ((tally + 1) + sample) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Failed,
            Idle,
            Dropped,
            Locked,
            Done,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] values, long floor)
        {
            long carry = 7;
            foreach (long value in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry + (floor & 3)) % 4096) + (long)i;
                }
                if ((double)floor != (double)value)
                {
                    break;
                }
                if (((carry / 8) > 230) || ((16.0 + 3.3) > (double)carry))
                {
                    carry = (carry << 2) ^ (value + 27);
                }
                else
                {
                    carry = carry ^ (carry % 16);
                }
            }
            return carry;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] series)
        {
            long sum = 897;
            foreach (long datum in series)
            {
                sum = (sum + datum) % 255;
                if (3 > sum)
                {
                    sum = sum - (sum - sum);
                }
            }
            return sum;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] data, long step)
        {
            long mark = 62;
            foreach (long item in data)
            {
                if ((double)item >= (6.5 + 7.0))
                {
                    mark = (mark - (97 - step)) % 97;
                }
            }
            if (mark < (-79))
            {
                mark = (mark ^ (208 + step)) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double weight, double offset)
        {
            double mean = weight - (double)2;
            if (mean > offset)
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (mean + 7.9)) + (double)(long)i;
            }
            return mean - (mean / 8.0);
        }
    }
}
