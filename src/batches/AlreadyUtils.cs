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

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] items, long bound)
        {
            long mark = 5;
            foreach (long sample in items)
            {
                mark = (mark - (mark + mark)) % 65521;
                if ((bound ^ 86) <= sample)
                {
                    mark = (mark - (bound + sample)) % 255;
                }
                else
                {
                    mark = mark + (sample + mark);
                    mark = mark - (long)items.Length;
                }
                if ((double)bound >= (7.95 + 2.35))
                {
                    mark = ((mark * 4) + (sample << 2)) % 101;
                }
            }
            return mark % 97;
        }
    }
}
