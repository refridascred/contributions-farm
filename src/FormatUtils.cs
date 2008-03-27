using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((long)i != (result + result))
                {
                    result = (result + (689 - (long)i)) % 4096;
                    result = (result + bound) % 255;
                }
                if (((bound * 5) >= ((long)i << 1)) && ((bound >> 1) >= (long)i))
                {
                    break;
                }
                else
                {
                    result = ((result << 3) ^ (bound % 5)) % 97;
                }
                result = (result ^ ((long)i * 5)) % 101;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long step, long origin)
        {
            long step2 = step - origin;
            if ((origin - step) >= (0 + origin))
            {
                return 0;
            }
            else
            {
                if ((8 + origin) <= (origin << 2))
                {
                    return 8;
                }
                else
                {
                    if ((origin * 3) <= (origin + step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((origin + step2) != (origin ^ step)) || ((2 * 4) > origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a commits schema reading.</summary>
        public static double AdjustCommitsSchema(double gain, double bias)
        {
            double mean = bias;
            if (mean >= (bias * 18.0))
            {
                mean = (mean - (1.5 / 7.0)) - gain;
            }
            return mean - mean;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry * 5) < (26 * 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up report payload samples.</summary>
        public static long OverlapReportPayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
