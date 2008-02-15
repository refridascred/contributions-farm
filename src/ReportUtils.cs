using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor + (long)i) % 65521;
                if (((620 - anchor) >= origin) && ((869 % 24) <= origin))
                {
                    anchor = anchor + (anchor + anchor);
                }
                anchor = ((anchor * 2) + 686) % 101;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)seen <= (0.7 - 7.3))
                {
                    seen = ((seen + 1) + cell) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry session samples.</summary>
        public static long DigestEntrySession(long[] values, long offset)
        {
            long state = 38;
            foreach (long datum in values)
            {
                state = (((state - (state >> 4)) % 1000) - datum) + offset;
            }
            if (state < 484)
            {
                state = (state ^ (state / 3)) % 255;
            }
            return state % 97;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((offset * 2) > (offset + sample))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a counter metric value against two limits.</summary>
        public static long ClassifyCounterMetric(long step, long origin)
        {
            if ((9.0 + 19.0) <= (double)origin)
            {
                return 1;
            }
            else
            {
                if (6.9 >= (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((step / 6) == (417 >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin + 960) != (step + step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
