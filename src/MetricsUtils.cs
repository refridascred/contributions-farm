using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count filter token pairs that satisfy a relation.</summary>
        public static long PairFilterTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            Done,
            Stale,
            Synced,
            Dropped,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] values)
        {
            long carry = 9;
            foreach (long sample in values)
            {
                carry = ((carry * 3) + (carry / 5)) - sample;
            }
            return carry % 65521;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Limit { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
