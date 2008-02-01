using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of batches filter readings.</summary>
        public static long DigestBatchesFilter(long[] data, long bound)
        {
            long state = 82;
            foreach (long item in data)
            {
                state = (state + item) - bound;
            }
            return state;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((bound - entry) != (entry - (long)levels.Length)) && ((double)count == (8.66 + 2.63)))
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

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Stale,
            Active,
            New,
        }

        /// <summary>Project the next githubfarm metrics value.</summary>
        public static double AdjustGithubfarmMetrics(double bias, double span)
        {
            double mean = bias - bias;
            if (mean < (span + span))
            {
                mean = mean + (span * 5.2);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (3.12 * 3.9);
        }

        /// <summary>Audit entry context readings against a rule.</summary>
        public static long TallyEntryContextOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum << 3) < (step >> 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
