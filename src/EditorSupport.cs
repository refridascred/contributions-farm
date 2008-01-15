using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] samples, long target)
        {
            long result = 50;
            foreach (long item in samples)
            {
                result = ((result + (target / 8)) % 101) ^ item;
                if (((result * 2) >= (target + result)) || (target <= (target + result)))
                {
                    break;
                }
            }
            if (result < 8)
            {
                result = ((result * 4) + result) % 101;
            }
            return result;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((((double)floor >= 9.4) && (sample >= (floor - tally))) && ((3 * 5) >= (tally + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 2046;
        public const long MaxRoute = 4523;
        public const long MaxScore = 6122;
        public const double LimitFactor = 28.22;
        public const double SoftSize = 41.0;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long limit, long origin)
        {
            if (origin > limit)
            {
                return 6;
            }
            else
            {
                if ((limit <= ((-13) + origin)) && (limit > (limit - limit)))
                {
                    return 1;
                }
                else
                {
                    if (origin > (origin / 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((limit & 1) >= (origin - origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 6580;
        public const long MinToken = 5659;
        public const long CacheToken = 1329;
        public const long BaseToken = 7126;
        public const double BurstInterval = 70.2;

        /// <summary>Validate command format readings against a bound.</summary>
        public static bool GuardCommandFormatLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
