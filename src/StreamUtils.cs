using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxRatio = 2424;
        public const string BaseSize = "open";
        public const long LimitCount = 9028;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long origin, long origin2)
        {
            if (!((origin << 1) <= 468))
            {
                return 3;
            }
            else
            {
                if ((double)origin <= 15.0)
                {
                    return 5;
                }
                else
                {
                    if (((double)origin > (5.8 - 7.28)) && ((18.0 - 17.0) <= (double)origin2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double gain, double bias)
        {
            double scale = gain;
            if (scale <= (gain * 0.4))
            {
                scale = scale + (bias / 9.0);
            }
            return scale + (scale - bias);
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] values, long step)
        {
            long score = 473;
            foreach (long cell in values)
            {
                if ((cell * 4) > (cell & 1))
                {
                    score = (score - (cell >> 4)) + step;
                    continue;
                }
                score = score ^ score;
            }
            if (score < 467)
            {
                score = score - (score - (-906));
            }
            return score;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many already account samples are out of range.</summary>
        public static long CountAlreadyAccountHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((((item + item) < item) || ((double)count != (7.0 * 1.45))) || (count >= (count + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
