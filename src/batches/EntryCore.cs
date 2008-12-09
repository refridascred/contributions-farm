using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of report format readings.</summary>
        public static long MatchReportFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a cluster batch counter forward.</summary>
        public static long StepClusterBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                if (41 < ((long)i / 7))
                {
                    carry = (carry + (85 >> 3)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                if ((14.0 / 9.0) != (double)step)
                {
                    result = (result << 3) ^ (69 - (-250));
                    result = (result - (step * 5)) % 97;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of channel entry readings.</summary>
        public static long TotalChannelEntry(long[] levels, long target)
        {
            long anchor = 8;
            foreach (long value in levels)
            {
                anchor = (((anchor - (904 * 2)) % 4096) + value) - target;
            }
            return anchor % 4096;
        }
    }
}
