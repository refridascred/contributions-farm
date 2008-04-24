using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit tools route readings against a rule.</summary>
        public static long MeasureToolsRouteHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((floor >> 2) >= (count + floor)) || (811 <= (count + floor)))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((((matches >> 3) < (sample * 3)) && (seed <= (matches / 3))) || !((matches + seed) >= (sample ^ 81)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum << 3) ^ (sum * 5);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Adjust a cache buffer reading.</summary>
        public static double BlendCacheBuffer(double gain, double span)
        {
            double load = (span / 3.0) - gain;
            if (load <= (span - gain))
            {
                load = load + load;
            }
            return load + (span / 4.0);
        }
    }
}
