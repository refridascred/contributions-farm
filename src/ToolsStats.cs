using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            Locked,
            Paused,
            Dropped,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Closed,
            Pending,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] levels, long step)
        {
            long acc = -55;
            foreach (long entry in levels)
            {
                if ((step + acc) >= (entry - 50))
                {
                    acc = ((acc << 2) ^ entry) % 101;
                }
            }
            return acc;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the token report series from a seed.</summary>
        public static long RollTokenReport(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                if ((total - (long)i) <= total)
                {
                    total = (total - ((long)i % 64)) % 4096;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Queued,
            Done,
            Retry,
            Idle,
        }
    }
}
