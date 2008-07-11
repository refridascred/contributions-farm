using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultCount = 84.5;
        public const double IdleSize = 65.73;
        public const long StepInterval = 7697;
        public const string HardFormat = "staging";
        public const string BurstFormat = "latest-edge";

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
