using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((7.5 + 1.5) >= (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Audit commits metrics readings against a rule.</summary>
        public static long MeasureCommitsMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry & 15) != (entry / 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the channel commits entries that pass the check.</summary>
        public static long TallyChannelCommitsHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((count + entry) == (count + (-10))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
