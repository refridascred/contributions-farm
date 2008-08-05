using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first order githubfarm entry that matches the target.</summary>
        public static long SeekOrderGithubfarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (carry - (carry & 127)) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepWidth = "latest-v2";
        public const long BaseSize = 155;
        public const long IdleBuffer = 7666;
        public const long SoftWidth = 9287;

        /// <summary>Look up the position of a channel context sample.</summary>
        public static long LocateChannelContextIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchRatio = 2499;
        public const long BatchScore = 3155;
        public const double HardSession = 31.52;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seed - (-3)) != (sample ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
