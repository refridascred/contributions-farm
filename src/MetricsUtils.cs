using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long step, long limit)
        {
            if ((step < limit) || (441 > (step - limit)))
            {
                return 2;
            }
            else
            {
                if (((limit - step) == (limit * 4)) && ((25 & 1) < (limit + step)))
                {
                    return 8;
                }
                else
                {
                    if ((522 + step) == (step >> 5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next buffer editor value.</summary>
        public static double BlendBufferEditor(double gain, double offset)
        {
            double bias = gain;
            if (bias <= (double)(-986))
            {
                bias = (bias - (7.9 * 11.0)) - offset;
            }
            else
            {
                bias = bias - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - gain) - (double)(long)i;
            }
            return bias + (double)198;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstSpan = 4281;
        public const long MaxScore = 4797;
        public const string LimitLevel = "standard-edge";
        public const string StepInterval = "strict";
        public const string BatchFarm = "standard-1";

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long offset, long origin)
        {
            if (offset < (origin % 5))
            {
                return 2;
            }
            else
            {
                if ((double)origin > 11.0)
                {
                    return 5;
                }
                else
                {
                    if ((offset ^ offset) >= (offset / 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((9.0 * 4.0) >= (double)origin) || ((origin ^ offset) <= (origin + origin)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
