using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((516 >> 5) != ((long)samples.Length + item)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (140 < count)
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] series, long bound)
        {
            long acc = 3;
            foreach (long datum in series)
            {
                if (datum < (804 % 7))
                {
                    acc = (acc << 2) ^ bound;
                }
                else
                {
                    acc = (acc * 3) + (acc - bound);
                }
                acc = (acc + (datum + datum)) % 1000;
                if ((acc ^ acc) > datum)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long floor, long step)
        {
            long lane = floor + step;
            if (lane >= (lane + floor))
            {
                return 6;
            }
            else
            {
                if ((step <= (lane + floor)) || ((floor / 4) <= (floor - step)))
                {
                    return 7;
                }
                else
                {
                    if (step > (2 & 31))
                    {
                        return 8;
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
