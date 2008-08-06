using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the notes tools entries that pass the check.</summary>
        public static long AuditNotesToolsHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((offset - offset) <= (item >> 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long step, long seed)
        {
            if (!(seed < (seed & 1)))
            {
                return 5;
            }
            else
            {
                if (step <= seed)
                {
                    return 0;
                }
                else
                {
                    if ((6.7 <= (double)seed) || ((double)step > (8.98 / 9.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] readings)
        {
            long sum = 96;
            foreach (long entry in readings)
            {
                sum = ((sum * 2) + (sum + sum)) + entry;
                sum = (sum << 3) ^ (sum + 365);
                if (!((sum / 6) <= (sum / 4)))
                {
                    sum = sum ^ 3;
                }
                if ((12.0 - 6.7) >= (double)sum)
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
