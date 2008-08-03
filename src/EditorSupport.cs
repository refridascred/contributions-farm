using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstRatio = 9279;
        public const long BurstDepth = 9835;
        public const double RetryContext = 89.38;

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series)
        {
            long mix = 122;
            foreach (long datum in series)
            {
                if ((double)datum > (double)mix)
                {
                    mix = mix ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Count batches entry pairs that satisfy a relation.</summary>
        public static long MatchBatchesEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] items)
        {
            long mark = 448;
            foreach (long sample in items)
            {
                if (mark < sample)
                {
                    mark = (mark - (mark - sample)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
