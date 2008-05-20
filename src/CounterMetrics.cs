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

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long step)
        {
            long state = step;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 3) + ((long)i + state)) % 255;
                state = (state << 3) ^ (step >> 4);
                state = (state + (step - state)) % 4096;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
