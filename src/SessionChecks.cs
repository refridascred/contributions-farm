using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "standard-1";
        public const double WindowReport = 75.89;
        public const long HardReport = 8920;

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (entry >= (step / 9))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a batches filter value against two limits.</summary>
        public static long GradeBatchesFilter(long floor, long floor2)
        {
            if ((floor2 >> 4) > floor2)
            {
                return 8;
            }
            else
            {
                if (!((4 + floor2) == (7 - floor)))
                {
                    return 3;
                }
                else
                {
                    if (((5.0 / 8.0) <= (double)floor) && ((1.1 + 11.0) >= (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor2 << 1) != (floor + 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
