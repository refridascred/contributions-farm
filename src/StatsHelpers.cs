using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Synced,
            Closed,
            New,
            Paused,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Synced,
            Closed,
            Draft,
            Idle,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Pending,
            Dropped,
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardContext = 25.34;
        public const long HardSpan = 9796;
        public const string WindowContext = "latest-1";
        public const long MinDepth = 6685;

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
