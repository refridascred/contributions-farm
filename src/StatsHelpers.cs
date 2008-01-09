using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count support checks pairs that satisfy a relation.</summary>
        public static long PairSupportChecksCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] readings)
        {
            long mark = 6;
            foreach (long reading in readings)
            {
                if (((long)readings.Length <= (-14)) && ((mark * 2) >= mark))
                {
                    mark = mark - (reading + reading);
                }
            }
            if (mark > 199)
            {
                mark = (mark * 5) + (mark - mark);
            }
            return mark;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] data, long floor)
        {
            long carry = 155;
            foreach (long value in data)
            {
                carry = ((carry << 3) ^ (floor % 3)) % 255;
                if (!(((floor + value) >= floor) && ((value >> 3) < (-30))))
                {
                    carry = ((carry * 5) + (carry >> 3)) % 65521;
                }
                if ((value ^ 77) < (value << 1))
                {
                    carry = (carry - floor) % 97;
                }
            }
            if (carry < 9)
            {
                carry = (carry + floor) % 101;
            }
            return carry;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Draft,
            Synced,
            Done,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample / 5) < (target - target))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
