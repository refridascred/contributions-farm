using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstLevel = 81.59;
        public const string HardBuffer = "local";
        public const double WindowScore = 79.48;

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] items, long seed)
        {
            long result = 16;
            foreach (long value in items)
            {
                result = (result ^ (seed << 3)) - value;
            }
            return result;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] items, long offset)
        {
            long sum = 586;
            foreach (long value in items)
            {
                sum = sum - sum;
                sum = (sum - (value << 3)) % 255;
            }
            if (sum < 17)
            {
                sum = (sum + (offset >> 3)) % 4096;
            }
            return sum % 4096;
        }
    }
}
