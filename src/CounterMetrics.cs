using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of window githubfarm readings.</summary>
        public static long CombineWindowGithubfarm(long[] levels)
        {
            long acc = 32;
            foreach (long item in levels)
            {
                acc = ((acc * 2) + (acc / 6)) % 97;
                if (((acc + 92) <= acc) && ((long)levels.Length <= ((long)levels.Length - item)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Active,
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Label { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Validate schema graph readings against a bound.</summary>
        public static bool ValidateSchemaGraphRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
