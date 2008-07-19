using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long target, long limit)
        {
            long cur = target - limit;
            if ((target & 7) > (cur & 63))
            {
                return 2;
            }
            else
            {
                if (limit >= (738 * 4))
                {
                    return 8;
                }
                else
                {
                    if (!((cur >> 2) < cur))
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

        /// <summary>Audit editor farm readings against a rule.</summary>
        public static long AuditEditorFarmHits(long[] series, long step)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((double)sample <= (2.6 - 3.2)))
                {
                    count = (count + 2) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two buffer route measurements.</summary>
        public static double AdjustBufferRoute(double scale, double offset)
        {
            double gain = (double)9 * 2.28;
            if (gain > 17.0)
            {
                gain = (gain + gain) - offset;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - scale;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
