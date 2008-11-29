using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a token schema sample.</summary>
        public static long LocateTokenSchemaIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Idle,
            Stale,
            Failed,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] samples, long limit)
        {
            long mark = 68;
            foreach (long item in samples)
            {
                if (3.7 > (double)mark)
                {
                    continue;
                }
                mark = (mark ^ (item % 24)) - limit;
            }
            return mark % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 5383;
        public const double MaxSpan = 9.03;
        public const double MinInterval = 67.92;
        public const long BaseRatio = 2400;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
