using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Count { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Draft,
            New,
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Adjust a order window reading.</summary>
        public static double SmoothOrderWindow(double gain, double offset)
        {
            double bias = (double)(-8) - offset;
            if (bias > bias)
            {
                bias = (bias - 0.71) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (7.7 * 9.2)) + (double)(long)i;
            }
            return bias - 0.8;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = ((state << 3) ^ (target & 15)) % 4096;
                state = state + state;
                if (((state + 2) != (597 + 954)) || ((89 & 127) <= (state - state)))
                {
                    state = ((state << 3) ^ (5 + target)) % 97;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count + count) != (98 % 7))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
