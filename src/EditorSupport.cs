using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long limit, long origin)
        {
            if (origin < (limit % 60))
            {
                return 3;
            }
            else
            {
                if (((17.0 / 3.0) < (double)limit) && (((-913) + limit) < (origin / 4)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Mode { get; set; } = "";
            public string Region { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Pending,
            Ready,
            Queued,
            Paused,
            New,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardLevel = 153;
        public const long BurstInterval = 4169;
        public const double LimitFormat = 51.83;
    }
}
