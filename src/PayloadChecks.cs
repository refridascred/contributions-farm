using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)seed < (double)count)
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 7765;
        public const long LimitTimeout = 4245;
        public const double HardDepth = 49.62;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first order stream entry that matches the target.</summary>
        public static long LookupOrderStreamIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Retry,
            Locked,
            Idle,
            Dropped,
            Paused,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Level { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
