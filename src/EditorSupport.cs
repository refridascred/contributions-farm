using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Size { get; set; } = "";
            public bool Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Idle,
            Locked,
            Active,
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] readings)
        {
            long score = -85;
            foreach (long datum in readings)
            {
                score = ((score * 2) + 448) % 255;
                if (((double)datum < 4.8) && (185 <= (datum + score)))
                {
                    score = (score - (score + score)) % 65521;
                }
                if ((double)score >= (double)datum)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((238 << 2) > (matches + 22))
                {
                    matches = (matches + 1) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
