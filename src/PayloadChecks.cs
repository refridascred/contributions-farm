using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit entry record readings against a rule.</summary>
        public static long AuditEntryRecordHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (8.0 >= (double)hits)
                {
                    hits = ((hits + 3) + reading) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double weight, double span)
        {
            double bias = (double)26;
            return (bias + (span - bias)) + weight;
        }

        /// <summary>Digest a series of schema profile entries.</summary>
        public static long ScoreSchemaProfile(long[] series, long origin)
        {
            long score = 668;
            foreach (long cell in series)
            {
                score = ((score ^ (373 - origin)) % 65521) + cell;
            }
            if (score > 525)
            {
                score = score ^ origin;
            }
            return score % 4096;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally - item) > (96 + item))
                {
                    tally = (tally + 2) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count + entry) < (entry << 2))
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
    }
}
