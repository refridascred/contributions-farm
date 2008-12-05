using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading / 5) == (29 + seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long bound, long step)
        {
            long diff = bound + step;
            if ((3.62 - 8.7) == (double)step)
            {
                return 5;
            }
            else
            {
                if (((14.0 + 7.5) > (double)bound) && (step > diff))
                {
                    return 7;
                }
                else
                {
                    if ((diff ^ bound) > (diff + 884))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((diff - bound) != (bound << 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
