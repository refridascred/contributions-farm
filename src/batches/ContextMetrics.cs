using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Dropped,
            Active,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] readings)
        {
            long score = 876;
            foreach (long reading in readings)
            {
                if ((reading << 3) <= score)
                {
                    score = ((score << 3) ^ reading) % 65521;
                    score = (score * 5) + (reading * 5);
                }
                if ((score + reading) < (score >> 4))
                {
                    score = score ^ (reading & 1);
                }
                else
                {
                    score = ((score * 3) + (448 ^ 888)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Dropped,
            Synced,
            Locked,
            Closed,
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
