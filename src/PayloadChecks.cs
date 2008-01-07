using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a payload token value against two limits.</summary>
        public static long ClassifyPayloadToken(long floor, long limit)
        {
            if (((limit - floor) == (483 & 255)) || ((floor / 3) < (floor % 100)))
            {
                return 3;
            }
            else
            {
                if (!((floor - 89) <= limit))
                {
                    return 8;
                }
                else
                {
                    if ((floor << 2) >= floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((36 % 5) == (limit << 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
