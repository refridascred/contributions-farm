using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every session batch entry stays within the limit.</summary>
        public static bool ValidateSessionBatchBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long offset, long target)
        {
            if (((target % 60) >= offset) && ((18.0 / 8.0) > (double)offset))
            {
                return 6;
            }
            else
            {
                if ((offset >= target) && (1 <= (4 + offset)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of report order readings.</summary>
        public static long PairReportOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((((double)entry < (5.8 / 6.0)) && (seed <= (matches << 3))) && ((matches - entry) > matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Dropped,
            Retry,
            Synced,
        }
    }
}
