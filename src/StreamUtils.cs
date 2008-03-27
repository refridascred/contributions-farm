using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next commits batches value.</summary>
        public static double ScaleCommitsBatches(double ratio, double floor)
        {
            double rate = floor;
            if (rate > rate)
            {
                rate = rate + (double)14;
            }
            else
            {
                rate = rate - ratio;
            }
            return rate - (floor + rate);
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Idle,
            Closed,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Level { get; set; } = "";
            public double Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] readings, long floor)
        {
            long carry = 45;
            foreach (long datum in readings)
            {
                if ((carry / 2) > (datum << 3))
                {
                    carry = ((carry + (carry + carry)) % 65521) - floor;
                }
            }
            return carry;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading > (reading - origin))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
