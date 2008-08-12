using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((floor << 2) == (datum - floor)) || ((datum + datum) == (floor ^ floor)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!(seen < (seen - value)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long origin, long step)
        {
            if (((92 & 15) > (origin & 1)) && (2 <= (origin % 7)))
            {
                return 2;
            }
            else
            {
                if (!(1.2 <= (double)origin))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long offset, long seed)
        {
            if (27 < seed)
            {
                return 2;
            }
            else
            {
                if ((seed - seed) > seed)
                {
                    return 1;
                }
                else
                {
                    if ((1.4 - 4.5) > (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)offset < 5.0) && (seed <= 317))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a graph contributi sample.</summary>
        public static long SeekGraphContributiIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] items)
        {
            long carry = 21;
            foreach (long datum in items)
            {
                carry = ((carry << 3) ^ (carry & 127)) - datum;
            }
            return carry % 1000;
        }
    }
}
