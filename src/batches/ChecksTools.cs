using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((1.2 <= (double)seen) || ((2 >> 2) < seen))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Count the window graph entries that pass the check.</summary>
        public static long CountWindowGraphHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (6.8 >= (double)matches)
                {
                    matches = ((matches + 3) - sample) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long bound, long origin)
        {
            if ((bound * 5) > bound)
            {
                return 7;
            }
            else
            {
                if ((bound ^ bound) > (origin + origin))
                {
                    return 6;
                }
                else
                {
                    if ((origin % 97) > 88)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin - bound) > (bound + 6))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
