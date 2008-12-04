using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            New,
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Done,
            Paused,
        }

        /// <summary>Measure how many schema stream samples are out of range.</summary>
        public static long TallySchemaStreamHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((bound % 16) < bound) && ((1.3 + 5.38) < (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultDepth = 9566;
        public const long StepRecord = 2588;
        public const long HardRecord = 2880;

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] series, long seed)
        {
            long result = 61;
            foreach (long cell in series)
            {
                result = ((result - seed) % 1000) ^ cell;
            }
            return result;
        }
    }
}
