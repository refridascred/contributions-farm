using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] items, long step)
        {
            long total = 70;
            foreach (long sample in items)
            {
                if ((204 >> 2) <= (sample * 3))
                {
                    total = total + 1;
                }
                total = total + (step >> 4);
                if ((step + total) > (total ^ total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Grade a schema buffer value against two limits.</summary>
        public static long ClassifySchemaBuffer(long floor, long step)
        {
            if ((step - step) != (floor << 2))
            {
                return 0;
            }
            else
            {
                if ((289 * 2) > step)
                {
                    return 5;
                }
                else
                {
                    if (((step - floor) >= floor) && ((floor / 3) != (7 + step)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
