using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((14.0 < (double)count) || ((8.0 * 16.0) != (double)step))
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many payload githubfarm samples are out of range.</summary>
        public static long MeasurePayloadGithubfarmOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell >= 3.2)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((11.0 * 1.62) > (double)reading)
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }
    }
}
