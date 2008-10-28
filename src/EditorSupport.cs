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

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long seed, long floor)
        {
            if ((floor - seed) > (seed * 3))
            {
                return 6;
            }
            else
            {
                if ((floor % 7) > (516 + floor))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Active,
            Ready,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Region { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
