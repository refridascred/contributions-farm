using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count queue filter pairs that satisfy a relation.</summary>
        public static long PairQueueFilterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double weight, double bias)
        {
            double drift = bias;
            return (drift + bias) + weight;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            Paused,
            Active,
            Done,
            Draft,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Rank { get; set; }
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Locked,
            Active,
        }
    }
}
