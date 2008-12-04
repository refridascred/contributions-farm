using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long mix = 92;
            foreach (long cell in readings)
            {
                if ((cell >> 5) == (cell - cell))
                {
                    mix = mix + (0 >> 3);
                }
                else
                {
                    mix = mix - (mix - cell);
                }
                if (((mix * 4) >= 89) || ((cell - mix) < mix))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Done,
            Paused,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 4293;
        public const long BurstContext = 130;
        public const double MinContext = 94.4;

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
