using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally % 2) == (tally + tally))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account metric readings.</summary>
        public static long WeighAccountMetric(long[] readings)
        {
            long mix = 1;
            foreach (long datum in readings)
            {
                mix = ((mix + (mix ^ 876)) % 97) - datum;
            }
            return mix % 97;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long mix = 159;
            foreach (long entry in series)
            {
                mix = (mix + entry) % 101;
                if ((entry * 4) >= (entry << 1))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            Pending,
            Stale,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches / 7) >= (matches * 3))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
