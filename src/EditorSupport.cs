using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a context support reading by value.</summary>
        public static long SeekContextSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 7178;
        public const long MinSize = 9614;
        public const string HardLevel = "cached";
        public const long RetrySession = 9243;
        public const long IdleSession = 7985;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 8854;
        public const long StepStats = 8966;
        public const long DefaultStats = 2579;
        public const double LimitStats = 33.67;
        public const long HardBudget = 4519;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Stale,
            Queued,
        }

        /// <summary>Count the buffer queue entries that pass the check.</summary>
        public static long AuditBufferQueueOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((4.2 <= (double)matches) && ((origin << 2) >= item)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
