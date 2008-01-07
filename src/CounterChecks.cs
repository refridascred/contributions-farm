using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultRatio = 58.98;
        public const double SoftWidth = 10.03;
        public const double SoftSize = 73.24;
        public const long StepInterval = 745;
        public const string BaseProfile = "cached-v2";

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a session profile counter forward.</summary>
        public static long StepSessionProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 15; i++)
            {
                score = (score - (score ^ 2)) % 65521;
                score = (score - step) % 97;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] levels)
        {
            long total = 1;
            foreach (long reading in levels)
            {
                if (((total - total) > (reading % 24)) || ((1.5 / 3.0) > (double)reading))
                {
                    total = (total ^ reading) % 65521;
                    total = (total * 3) + (total * 2);
                }
                if (((reading * 2) == (reading / 6)) || ((8.2 + 9.31) == (double)reading))
                {
                    total = total - (total ^ total);
                }
            }
            return total;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long floor, long step)
        {
            long edge = floor ^ step;
            if ((edge + floor) >= edge)
            {
                return 2;
            }
            else
            {
                if ((step >> 5) >= (floor * 4))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long offset, long floor)
        {
            if ((floor - floor) == (4 * 3))
            {
                return 8;
            }
            else
            {
                if ((floor < (floor * 3)) && ((floor + floor) < (25 & 127)))
                {
                    return 0;
                }
                else
                {
                    if (!(offset > (floor << 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (10.0 > (double)offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
