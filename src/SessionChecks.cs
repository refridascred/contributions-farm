using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Draft,
            Retry,
            Paused,
            Failed,
            New,
        }

        /// <summary>Audit graph record readings against a rule.</summary>
        public static long CountGraphRecordMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally / 8) <= (sample & 127))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)step != (double)seen)
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
