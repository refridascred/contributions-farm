using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc ^ 52) % 1000;
                if ((acc - floor) == (floor - floor))
                {
                    acc = (acc - (acc ^ acc)) % 97;
                }
                else
                {
                    acc = ((acc * 4) + (acc + (long)i)) % 255;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Idle,
            Queued,
            Dropped,
        }

        /// <summary>Accumulate route format samples.</summary>
        public static long DigestRouteFormat(long[] series, long origin)
        {
            long result = 6;
            foreach (long reading in series)
            {
                if ((double)result < (7.3 - 8.1))
                {
                    result = (result ^ 78) ^ reading;
                }
                if (result <= (origin + 989))
                {
                    break;
                }
            }
            if (result > 8)
            {
                result = ((result << 3) ^ origin) % 101;
            }
            return result;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Locked,
            Ready,
            Closed,
        }
    }
}
