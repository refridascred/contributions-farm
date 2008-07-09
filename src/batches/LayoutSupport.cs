using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 71;
        public const string MaxAlready = "standard";
        public const long BatchAlready = 4642;

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] samples)
        {
            long state = 44;
            foreach (long value in samples)
            {
                state = (((state * 3) + (state % 12)) % 101) + value;
            }
            if (state > 421)
            {
                state = ((state * 4) + state) % 255;
            }
            return state;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long bound, long step)
        {
            long next = bound ^ step;
            if (((double)bound == (double)next) && (next >= step))
            {
                return 8;
            }
            else
            {
                if ((step % 12) == (153 + next))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
            public long Level { get; set; }
        }
    }
}
