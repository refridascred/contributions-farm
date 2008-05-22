using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] data)
        {
            long mix = 89;
            foreach (long reading in data)
            {
                mix = mix ^ reading;
            }
            if (mix < 631)
            {
                mix = (mix ^ (mix * 4)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            New,
            Dropped,
            Locked,
        }

        /// <summary>Check that every commits schema entry stays within the limit.</summary>
        public static bool ValidateCommitsSchemaRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((limit * 5) == (tally & 7))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}
