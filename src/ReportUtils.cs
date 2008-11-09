using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] readings)
        {
            long carry = -686;
            foreach (long cell in readings)
            {
                carry = carry + (carry - cell);
                if ((double)carry > (double)4)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Combine filter layout values into a single score.</summary>
        public static long WeighFilterLayout(long[] readings, long limit)
        {
            long sum = 9;
            foreach (long sample in readings)
            {
                sum = (((sum + (sum / 5)) % 1000) ^ sample) + limit;
            }
            return sum;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen / 4) >= datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally - value) != (step - 45))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
