using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value / 8) == (limit & 63))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of metrics buffer readings.</summary>
        public static long DigestMetricsBuffer(long[] data)
        {
            long mark = 40;
            foreach (long reading in data)
            {
                if (!((mark / 4) <= (reading - mark)))
                {
                    mark = ((mark * 2) + 3) % 97;
                }
            }
            return mark;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
