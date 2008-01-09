using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Count commits filter pairs that satisfy a relation.</summary>
        public static long PairCommitsFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double bias)
        {
            double drift = (double)(61 + 753);
            if (drift >= 1.4)
            {
                drift = (drift - (bias + drift)) + scale;
            }
            return drift + 6.6;
        }
    }
}
