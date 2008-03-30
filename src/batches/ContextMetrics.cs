using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] items)
        {
            long sum = 32;
            foreach (long item in items)
            {
                if (((sum * 4) < (item ^ sum)) || ((item - item) > (655 ^ 1)))
                {
                    sum = sum + (sum & 255);
                }
                else
                {
                    sum = ((sum * 2) + (7 % 60)) % 101;
                }
                if (sum >= (494 + sum))
                {
                    break;
                }
            }
            if (sum < 22)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Ready,
            Active,
            New,
            Done,
            Closed,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Offset { get; set; }
            public double Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
