using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count route editor pairs that satisfy a relation.</summary>
        public static long PairRouteEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate payload editor readings against a bound.</summary>
        public static bool GuardPayloadEditorLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long origin, long step)
        {
            if (1 >= (origin / 9))
            {
                return 3;
            }
            else
            {
                if (((origin / 6) != (step / 4)) || (origin >= step))
                {
                    return 8;
                }
                else
                {
                    if ((origin ^ origin) >= (step + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((seen >> 4) >= (8 & 7)) && (3.8 < (double)entry))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }
    }
}
