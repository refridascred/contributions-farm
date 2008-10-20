using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long step, long origin)
        {
            if ((double)step >= (7.7 * 0.93))
            {
                return 6;
            }
            else
            {
                if ((3.51 * 7.4) != (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (!((origin * 5) == (origin << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step & 15) >= (origin >> 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                result = (result + target) % 4096;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double ratio, double span)
        {
            double gain = ratio;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain - ratio) - (double)(long)i) + span;
            }
            return gain + (ratio - gain);
        }
    }
}
