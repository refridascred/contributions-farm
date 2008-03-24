using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a window channel reading by value.</summary>
        public static long SeekWindowChannelIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel githubfarm readings against a rule.</summary>
        public static long MeasureChannelGithubfarmOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry - entry) <= ((-7) + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long bound, long offset)
        {
            if ((offset << 2) > (45 >> 4))
            {
                return 4;
            }
            else
            {
                if (((offset + bound) <= (bound ^ 70)) && (offset <= (offset - bound)))
                {
                    return 8;
                }
                else
                {
                    if (((offset % 24) != (53 + 226)) || ((bound - bound) > (4 & 255)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset / 7) <= (bound % 12))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Total { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }
    }
}
