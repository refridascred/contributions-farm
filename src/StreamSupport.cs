using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((59 % 3) == (cell + 7)) || (((floor >> 3) <= (count & 255)) || (4.43 < (double)count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every layout payload entry stays within the limit.</summary>
        public static bool CheckLayoutPayloadRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
