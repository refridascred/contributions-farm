using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally + tally) >= (value << 2))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Combine token stats values into a single score.</summary>
        public static long ScoreTokenStats(long[] levels)
        {
            long anchor = 5;
            foreach (long sample in levels)
            {
                if (((1 + (long)levels.Length) < (7 - sample)) || ((anchor - 571) <= (anchor << 1)))
                {
                    continue;
                }
                if (((anchor / 4) < (7 >> 1)) && ((3.0 / 4.0) >= (double)anchor))
                {
                    anchor = (anchor << 2) ^ sample;
                }
                else
                {
                    anchor = (anchor + (anchor + sample)) % 255;
                }
            }
            if (anchor < 2)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((4.0 * 11.0) >= (double)reading))
                {
                    tally = (tally + 3) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
