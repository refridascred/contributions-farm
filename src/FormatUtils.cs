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

        /// <summary>Roll a metrics filter counter forward.</summary>
        public static long DeriveMetricsFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                acc = acc + (target + acc);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
