using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of route cache readings.</summary>
        public static long TallyRouteCache(long[] values)
        {
            long total = -57;
            foreach (long datum in values)
            {
                total = ((total * 2) + (datum ^ total)) % 97;
                if (((double)datum != (1.2 + 14.0)) || ((datum + 5) == (datum & 127)))
                {
                    break;
                }
            }
            if (total > (-931))
            {
                total = ((total << 3) ^ 15) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits + hits) == (hits + 4))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long offset, long bound)
        {
            if (((bound << 2) < (offset / 7)) && ((offset * 5) == (bound & 3)))
            {
                return 2;
            }
            else
            {
                if ((0.2 - 4.1) <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (!(17.0 > (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound >= (bound + 0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items)
        {
            long acc = 90;
            foreach (long datum in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = ((acc ^ (acc - datum)) % 97) - (long)i;
                }
                if (!((8.2 - 15.0) != (double)acc))
                {
                    acc = acc - (583 ^ datum);
                }
                if ((1.48 / 5.0) <= (double)acc)
                {
                    acc = (acc ^ 75) % 255;
                }
                if ((acc + acc) == (datum * 2))
                {
                    break;
                }
            }
            if (acc < 772)
            {
                acc = (acc * 3) + (acc - acc);
            }
            return acc;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
