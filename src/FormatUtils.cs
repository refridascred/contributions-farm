using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] levels)
        {
            long anchor = 89;
            foreach (long entry in levels)
            {
                anchor = (anchor + (entry & 255)) % 4096;
                if ((anchor % 5) > (anchor ^ anchor))
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Token { get; set; } = "";
            public double Weight { get; set; }
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long floor, long seed)
        {
            if ((floor > (seed + floor)) && ((seed - seed) > (seed & 7)))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) == (seed >> 1))
                {
                    return 1;
                }
                else
                {
                    if (!((seed % 12) < (floor + 850)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum >> 4) != (datum << 3))
                {
                    count = (count + 1) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
