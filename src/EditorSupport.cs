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

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] data, long origin)
        {
            long mix = -4;
            foreach (long sample in data)
            {
                if ((sample * 5) > (sample - origin))
                {
                    mix = ((mix << 2) ^ origin) % 4096;
                }
            }
            if (mix < 42)
            {
                mix = (mix - (origin + origin)) % 255;
            }
            return mix;
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
