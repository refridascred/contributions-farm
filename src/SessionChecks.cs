using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Ready,
            Stale,
            Dropped,
            New,
            Active,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Iterate the order notes series from a seed.</summary>
        public static long StepOrderNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ (step << 1)) % 101;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                if (!((289 << 1) >= step))
                {
                    continue;
                }
                else
                {
                    mark = mark + (step - mark);
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
