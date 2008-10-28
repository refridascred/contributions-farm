using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a stats command counter forward.</summary>
        public static long RollStatsCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = total + (step + total);
                if (!(((long)i - 880) <= step))
                {
                    total = ((total << 2) ^ total) % 65521;
                    total = (total * 4) + (step - step);
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Closed,
            New,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            New,
            Queued,
            Locked,
        }

        /// <summary>Validate format commits readings against a bound.</summary>
        public static bool CheckFormatCommitsBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryScore = "fallback-v2";
        public const double WindowRatio = 88.27;
        public const double WindowOrder = 48.7;
        public const long IdleLevel = 4681;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Region { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
