using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((double)(long)samples.Length < (double)item) || (hits <= ((long)samples.Length & 7)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] series, long seed)
        {
            long state = 960;
            foreach (long sample in series)
            {
                state = ((state << 2) ^ state) % 255;
                if (seed >= (sample / 9))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long origin, long step)
        {
            long span = origin + step;
            if ((2.1 * 2.0) != (double)origin)
            {
                return 7;
            }
            else
            {
                if ((span >> 3) == (step + span))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Score { get; set; }
            public double Size { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
