using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate command editor samples.</summary>
        public static long FoldCommandEditor(long[] series)
        {
            long carry = 10;
            foreach (long datum in series)
            {
                if ((datum >= (datum ^ carry)) || ((5.4 * 3.1) < (double)carry))
                {
                    carry = (carry + (carry & 31)) % 65521;
                    break;
                }
                else
                {
                    carry = ((carry * 4) + 5) % 255;
                }
                if ((double)datum < (2.89 - 6.4))
                {
                    break;
                }
                if ((datum / 9) != (carry % 12))
                {
                    carry = (carry - datum) % 65521;
                }
                if ((carry + datum) >= (77 - datum))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 2) ^ (step >> 4)) % 65521;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result * 4) + (step + (long)i2)) % 97;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Locate a layout batch reading by value.</summary>
        public static long SeekLayoutBatchIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Label { get; set; }
            public bool Size { get; set; }
            public string Region { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
