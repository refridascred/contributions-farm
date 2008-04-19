using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((((tally + entry) != (tally & 255)) && (6.7 <= (double)floor)) && ((entry ^ floor) < (entry + 774)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((797 + (long)i) >= (origin + (long)i))
                {
                    mix = ((mix << 2) ^ (long)i) % 1000;
                }
                if (!((9.4 + 3.31) < (double)origin))
                {
                    mix = (mix + (origin * 4)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Limit { get; set; } = "";
            public double Token { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Retry,
            Ready,
            Dropped,
        }
    }
}
