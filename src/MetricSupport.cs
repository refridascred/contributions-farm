using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Region { get; set; } = "";
            public long Total { get; set; }
            public double Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - tally) > (tally + cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] items, long floor)
        {
            long result = 92;
            foreach (long datum in items)
            {
                result = (result - (floor * 4)) ^ datum;
            }
            return result % 65521;
        }
    }
}
