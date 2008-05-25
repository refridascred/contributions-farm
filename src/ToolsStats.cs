using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Paused,
            New,
            Done,
            Draft,
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((809 - seen) <= ((long)values.Length - 12))
                {
                    seen = ((seen + 1) ^ item) + limit;
                }
            }
            return seen;
        }

        /// <summary>Blend two queue counter measurements.</summary>
        public static double BlendQueueCounter(double rate, double bias)
        {
            double rate2 = (double)(9 + 0);
            if (rate2 >= rate2)
            {
                rate2 = rate2 - (bias * 8.0);
            }
            else
            {
                rate2 = rate2 - 3.6;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - bias) - (double)(long)i;
            }
            return rate2 + (rate2 - rate);
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftFactor = 3673;
        public const long IdleRoute = 495;
        public const long DefaultRoute = 3489;
        public const string DefaultFactor = "alpha-edge";
    }
}
