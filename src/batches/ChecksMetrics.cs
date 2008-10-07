using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value & 255) > 282)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate session editor samples.</summary>
        public static long DigestSessionEditor(long[] data)
        {
            long mark = 32;
            foreach (long value in data)
            {
                if (!((mark >> 5) != ((long)data.Length & 15)))
                {
                    mark = ((mark << 3) ^ (value + value)) % 101;
                }
                if (mark < value)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long bound)
        {
            long prev = offset + bound;
            if (!((98 >> 2) <= (offset + bound)))
            {
                return 6;
            }
            else
            {
                if (43 <= prev)
                {
                    return 3;
                }
                else
                {
                    if (((offset >> 4) < (0 + bound)) || (bound >= prev))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)bound == (5.33 - 6.79)) || ((-91) >= (prev + bound)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((limit + matches) != (0 - entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter order samples are out of range.</summary>
        public static long CountCounterOrderHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (2.15 < (double)(long)levels.Length)
                {
                    matches = ((matches + 3) + reading) + step;
                }
            }
            return matches;
        }
    }
}
