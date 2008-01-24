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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum % 60) > (datum + 0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

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
