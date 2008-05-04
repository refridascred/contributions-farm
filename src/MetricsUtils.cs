using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen % 97) >= (55 >> 1))
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the profile order entries that pass the check.</summary>
        public static long AuditProfileOrderGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(((long)items.Length << 1) < bound))
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] values)
        {
            long mix = 3;
            foreach (long cell in values)
            {
                if ((77 - mix) == (cell ^ (long)values.Length))
                {
                    mix = ((mix * 3) + (mix - mix)) % 97;
                }
            }
            return mix;
        }
    }
}
