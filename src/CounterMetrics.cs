using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit graph route readings against a rule.</summary>
        public static long MeasureGraphRouteOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((datum - datum) < datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a command profile sample.</summary>
        public static long SeekCommandProfileIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up notes graph samples.</summary>
        public static long OverlapNotesGraphCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
