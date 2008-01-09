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

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
            public bool Score { get; set; }
            public string Region { get; set; } = "";
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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value + 32) < (bound & 3))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((5.0 / 6.0) > (double)count) || (((16.0 + 5.35) <= (double)datum) || ((double)39 <= (double)count)))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }
    }
}
