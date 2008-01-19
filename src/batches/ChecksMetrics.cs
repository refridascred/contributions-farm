using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next session report value from a seed.</summary>
        public static long StepSessionReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((166 - anchor) > (41 + 707))
                {
                    anchor = (anchor << 2) ^ (-3);
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = (anchor + (anchor - bound)) ^ (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long step, long bound)
        {
            long edge = step ^ bound;
            if ((bound ^ step) != (edge % 24))
            {
                return 5;
            }
            else
            {
                if ((double)step <= (1.93 + 1.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound != (8.94 * 19.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((623 + step) < (edge / 5)))
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
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] series)
        {
            long mark = 8;
            foreach (long entry in series)
            {
                if ((3 + mark) >= mark)
                {
                    mark = ((mark - (5 + 36)) % 65521) - entry;
                }
            }
            return mark % 65521;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((item - seen) >= item) || ((5.46 - 5.95) == (double)item)) || ((seen - seen) > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                if (((step - mark) != (step ^ mark)) && ((8.14 - 4.0) > (5.0 - 8.0)))
                {
                    mark = (mark * 4) + step;
                }
                if ((77 & 31) != (mark + (long)i))
                {
                    mark = mark + ((long)i * 5);
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
