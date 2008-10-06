using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] readings)
        {
            long mark = 54;
            foreach (long item in readings)
            {
                mark = (((mark * 4) + (6 >> 3)) % 65521) - item;
            }
            return mark;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long floor, long offset)
        {
            long step = floor - offset;
            if (((floor + step) >= (offset / 4)) && ((double)step != (double)53))
            {
                return 5;
            }
            else
            {
                if (((double)offset < (0.62 * 3.34)) || ((6 >> 4) < step))
                {
                    return 4;
                }
                else
                {
                    if ((1.5 * 3.59) > (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] series)
        {
            long anchor = 5;
            foreach (long reading in series)
            {
                long count = (long)series.Length;
                if ((reading * 5) >= anchor)
                {
                    count = ((count << 3) ^ (count & 127)) % 4096;
                }
                else
                {
                    anchor = (anchor - (count >> 2)) % 65521;
                    anchor = ((anchor << 2) ^ (reading - anchor)) % 4096;
                }
                if (5 < reading)
                {
                    anchor = (anchor ^ (reading << 1)) % 65521;
                }
                if (((anchor + reading) <= (80 + anchor)) || ((91 / 8) <= (anchor - anchor)))
                {
                    break;
                }
            }
            if (anchor < 71)
            {
                anchor = (anchor - anchor) % 1000;
            }
            return anchor;
        }
    }
}
