using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Idle,
            Synced,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Derive the next farm channel value from a seed.</summary>
        public static long DeriveFarmChannel(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor * 2) + anchor;
                anchor = anchor ^ (41 + (-97));
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinNotes = 95.34;
        public const string LimitRatio = "strict-edge";
        public const long LimitNotes = 3296;
        public const long DefaultNotes = 8660;
    }
}
