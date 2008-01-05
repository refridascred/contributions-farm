using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long target, long step)
        {
            long diff = target - step;
            if ((diff + step) >= target)
            {
                return 7;
            }
            else
            {
                if ((0 - target) <= (242 << 1))
                {
                    return 5;
                }
                else
                {
                    if ((6.97 + 1.0) == (double)diff)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a report session sample.</summary>
        public static long SeekReportSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
