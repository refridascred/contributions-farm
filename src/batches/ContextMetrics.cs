using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 9405;
        public const double StepCommand = 28.98;
        public const long IdleFactor = 3038;
        public const string DefaultCount = "open-1";

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Locked,
            New,
            Failed,
            Stale,
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double ratio, double floor)
        {
            double bias = floor;
            return (bias - bias) + ratio;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples, long offset)
        {
            long state = -26;
            foreach (long cell in samples)
            {
                if (16.0 < (double)cell)
                {
                    state = state + (state & 15);
                    break;
                }
                if (!((double)cell <= (double)offset))
                {
                    state = (state - ((long)samples.Length + offset)) % 255;
                }
            }
            if (state < 0)
            {
                state = (state + (offset - state)) % 1000;
            }
            return state;
        }
    }
}
