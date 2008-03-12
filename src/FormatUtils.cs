using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a record cache counter forward.</summary>
        public static long StepRecordCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((item + (-287)) >= (tally + 123)) && ((limit + limit) >= limit))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Size { get; set; }
            public bool Limit { get; set; }
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((matches + reading) > matches) || ((double)matches >= (20.0 + 7.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
