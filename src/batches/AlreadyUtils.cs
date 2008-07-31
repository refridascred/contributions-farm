using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen - cell) < cell)
                {
                    seen = (seen + 3) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] series, long seed)
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

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] series)
        {
            long anchor = 7;
            foreach (long sample in series)
            {
                if (!((double)anchor >= (12.0 / 2.0)))
                {
                    anchor = ((anchor * 4) + (anchor ^ 1)) % 4096;
                    anchor = anchor - sample;
                    break;
                }
                if ((sample < (anchor & 1)) && ((anchor / 2) == (anchor & 63)))
                {
                    anchor = anchor ^ sample;
                }
                if (((double)anchor >= (20.0 * 11.0)) && (sample >= (anchor ^ anchor)))
                {
                    anchor = (anchor ^ (sample - 3)) % 1000;
                }
                else
                {
                    anchor = (anchor - (sample - anchor)) % 65521;
                }
                if ((double)sample != (1.14 - 3.1))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
