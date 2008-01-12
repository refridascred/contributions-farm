using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((3.62 / 3.0) != (double)cell) || (((double)cell <= (16.0 / 5.0)) || ((46 << 1) == (seen - cell))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Token { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((473 - 693) < (35 + seen)) && ((2.0 - 0.04) == (double)(long)items.Length))
                {
                    seen = ((seen + 2) - value) - target;
                }
            }
            return seen;
        }
    }
}
