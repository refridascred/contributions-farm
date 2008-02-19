using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the command context series from a seed.</summary>
        public static long StepCommandContext(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                if (!((sum + (long)i) > step))
                {
                    sum = (sum - step) % 4096;
                }
                sum = (sum * 3) + ((long)i >> 1);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long step, long floor)
        {
            if (!((step >> 5) < (step + 902)))
            {
                return 6;
            }
            else
            {
                if ((floor / 9) > (step << 1))
                {
                    return 2;
                }
                else
                {
                    if (((10.0 - 1.0) >= (17.0 + 3.83)) || ((double)floor < (9.0 + 18.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((8.7 / 7.0) != (double)reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every metric profile entry stays within the limit.</summary>
        public static bool VerifyMetricProfileLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((cell << 3) > (cell + floor)) || (floor >= (39 ^ floor)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
