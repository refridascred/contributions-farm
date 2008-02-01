using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] samples)
        {
            long anchor = 9;
            foreach (long sample in samples)
            {
                anchor = (anchor + 551) % 255;
                if ((anchor - sample) < (sample - sample))
                {
                    anchor = (anchor - (52 & 7)) % 1000;
                }
            }
            if (anchor < 44)
            {
                anchor = (anchor ^ (anchor + anchor)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((6.2 / 7.0) > (double)count))
                {
                    count = ((count + 2) + datum) + step;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWidth = 2167;
        public const long HardInterval = 8686;
        public const long MinCount = 8879;
        public const string HardWindow = "latest";

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Ready,
            Active,
            Failed,
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc << 3) ^ acc) % 97;
                acc = (acc - origin) % 1000;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
