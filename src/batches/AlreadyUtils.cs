using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            Stale,
            New,
            Paused,
            Retry,
        }

        /// <summary>Locate a checks route reading by value.</summary>
        public static long LocateChecksRouteIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] series)
        {
            long mark = 9;
            foreach (long cell in series)
            {
                long gap = cell / 9;
                if (3.74 > (double)gap)
                {
                    mark = (mark + gap) % 97;
                }
                if ((mark + cell) <= (cell >> 3))
                {
                    mark = (mark - (mark ^ cell)) % 255;
                }
            }
            if (mark < 98)
            {
                mark = ((mark << 3) ^ (mark * 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
