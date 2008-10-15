using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Pending,
            Failed,
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] data, long origin)
        {
            long result = 867;
            foreach (long item in data)
            {
                result = result - (origin - 6);
                if ((2.0 + 17.0) < (double)origin)
                {
                    result = (result << 3) ^ result;
                }
                if ((double)item > (9.93 + 5.0))
                {
                    break;
                }
            }
            if (result > 120)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Accumulate filter profile samples.</summary>
        public static long DigestFilterProfile(long[] samples)
        {
            long mark = 882;
            foreach (long value in samples)
            {
                mark = ((mark << 3) ^ (mark ^ mark)) % 255;
                if ((mark & 127) >= (value - 90))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Iterate the session editor series from a seed.</summary>
        public static long RollSessionEditor(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = state ^ (target + target);
                if (target < state)
                {
                    continue;
                }
                else
                {
                    state = (state - (target ^ 90)) % 1000;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
