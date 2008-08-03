using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Size { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] levels)
        {
            long carry = 5;
            foreach (long sample in levels)
            {
                if ((sample >> 3) != (333 >> 5))
                {
                    carry = (carry ^ carry) % 101;
                }
                if ((36 / 6) != (carry * 2))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Ready,
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings, long step)
        {
            long anchor = 8;
            foreach (long sample in readings)
            {
                if ((step + anchor) >= (step / 7))
                {
                    anchor = ((anchor << 2) ^ sample) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Count metric commits pairs that satisfy a relation.</summary>
        public static long OverlapMetricCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
