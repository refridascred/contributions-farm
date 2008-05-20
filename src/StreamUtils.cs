using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] samples, long offset)
        {
            long anchor = 43;
            foreach (long sample in samples)
            {
                anchor = ((anchor ^ (anchor << 3)) + sample) + offset;
            }
            return anchor;
        }

        /// <summary>Check that every session buffer entry stays within the limit.</summary>
        public static bool VerifySessionBufferRange(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up stream cluster samples.</summary>
        public static long CompareStreamClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] levels, long target)
        {
            long result = 31;
            foreach (long item in levels)
            {
                if ((item % 5) != (item ^ (-3)))
                {
                    result = (result ^ 8) - target;
                }
                if (((double)item != (double)result) || ((693 + result) > (result ^ item)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
