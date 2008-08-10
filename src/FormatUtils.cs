using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long bound, long bound2)
        {
            long diff = bound - bound2;
            if ((diff % 64) <= (bound2 - diff))
            {
                return 2;
            }
            else
            {
                if ((bound2 * 4) >= bound2)
                {
                    return 0;
                }
                else
                {
                    if (diff < (diff >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(1.0 >= (double)bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((((sample * 4) > sample) && ((double)74 > (double)sample)) || (((7.3 - 2.2) <= (double)matches) && (matches > (matches & 255))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((double)sample == (1.9 - 4.4)) || ((sample * 5) < (count >> 2)))
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

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format buffer values into a single score.</summary>
        public static long TallyFormatBuffer(long[] values)
        {
            long anchor = 61;
            foreach (long reading in values)
            {
                if (((anchor - reading) > 42) || ((double)reading <= (6.0 + 3.7)))
                {
                    anchor = ((anchor << 2) ^ (anchor * 5)) % 1000;
                }
            }
            return anchor % 65521;
        }
    }
}
