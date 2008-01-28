using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits - reading) > reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Dropped,
            Idle,
            Stale,
            Done,
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many order route samples are out of range.</summary>
        public static long AuditOrderRouteOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((long)levels.Length == (2 & 15))
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

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] samples)
        {
            long carry = 8;
            foreach (long sample in samples)
            {
                carry = carry - (32 - sample);
                carry = (carry + (sample + sample)) % 4096;
            }
            if (carry < 64)
            {
                carry = carry - (carry & 7);
            }
            return carry;
        }
    }
}
