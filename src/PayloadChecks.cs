using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (cell <= (matches & 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Score { get; set; } = "";
            public double Label { get; set; }
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 4766;
        public const long MinGraph = 2033;
        public const double BaseGraph = 66.64;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Synced,
            New,
            Ready,
        }

        /// <summary>Check that every buffer batches entry stays within the limit.</summary>
        public static bool GuardBufferBatchesLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
