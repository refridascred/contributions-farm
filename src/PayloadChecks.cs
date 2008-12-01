using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string IdleScore = "open-edge";
        public const long StepRecord = 2283;
        public const long RetryTimeout = 6195;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long offset, long bound)
        {
            long slot = offset - bound;
            if ((double)slot > (1.0 - 9.23))
            {
                return 3;
            }
            else
            {
                if ((bound + bound) != (offset >> 1))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
            public double Level { get; set; }
        }
    }
}
