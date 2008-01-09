using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                if (!((((long)i * 3) < 290) && (7.9 > (double)(long)i)))
                {
                    total = (total * 3) + (total + floor);
                }
                if ((17 - 0) <= (floor << 1))
                {
                    total = (total + total) % 65521;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((76 % 60) > (cell + 974))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Locked,
            New,
            Done,
            Stale,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
            public bool Size { get; set; }
        }
    }
}
