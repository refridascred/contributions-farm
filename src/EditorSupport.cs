using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            New,
            Active,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long floor)
        {
            long span = target + floor;
            if (((7 * 4) < (target >> 4)) || ((double)span >= (5.5 + 6.18)))
            {
                return 1;
            }
            else
            {
                if ((span + span) < span)
                {
                    return 4;
                }
                else
                {
                    if ((target + span) != (73 >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Idle,
            Queued,
            Paused,
            Retry,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 42.5;
        public const string LimitFilter = "legacy-1";
        public const long HardFilter = 1527;
        public const long DefaultFilter = 2441;

        /// <summary>Validate graph tools readings against a bound.</summary>
        public static bool ValidateGraphToolsBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
