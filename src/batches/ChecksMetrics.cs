using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of stream commits entries.</summary>
        public static long TotalStreamCommits(long[] items, long target)
        {
            long state = 17;
            foreach (long cell in items)
            {
                state = (state ^ (32 + target)) + cell;
            }
            return state;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxSize = "standard-v2";
        public const double CacheFactor = 38.3;
        public const string StepTimeout = "standard-edge";
        public const double IdleSize = 38.64;

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            Pending,
            Dropped,
            Retry,
        }
    }
}
