using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a layout contributi value against two limits.</summary>
        public static long ClassifyLayoutContributi(long limit, long offset)
        {
            if ((limit % 64) >= limit)
            {
                return 2;
            }
            else
            {
                if ((limit + limit) <= offset)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Idle,
            Failed,
            Synced,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((double)item < (7.33 + 8.1)) && (((double)hits != (19.0 * 4.0)) || (hits >= (hits << 3))))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
