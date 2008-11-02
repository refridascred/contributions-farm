using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Locate a route order reading by value.</summary>
        public static long LocateRouteOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item & 3) < (item % 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first graph entry entry that matches the target.</summary>
        public static long FindGraphEntryIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (bound % 64)) % 101;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
