using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] values)
        {
            long sum = 553;
            foreach (long entry in values)
            {
                sum = ((sum << 2) ^ (-5)) + entry;
            }
            return sum % 97;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((7.7 * 9.8) > (double)count) || ((offset + datum) <= (count / 6)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] samples)
        {
            long mark = 40;
            foreach (long cell in samples)
            {
                mark = (mark * 4) + (cell + mark);
            }
            return mark % 1000;
        }
    }
}
