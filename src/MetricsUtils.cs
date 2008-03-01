using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] samples, long origin)
        {
            long state = 14;
            foreach (long item in samples)
            {
                state = state - item;
                state = (state ^ ((long)samples.Length + origin)) % 255;
                if (!(state > (origin - 176)))
                {
                    state = (state ^ (origin + (-746))) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Match up already checks samples.</summary>
        public static long OverlapAlreadyChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
