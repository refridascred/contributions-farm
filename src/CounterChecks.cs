using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Queued,
            Draft,
            Ready,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally + 621) <= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next buffer farm value from a seed.</summary>
        public static long SeriesBufferFarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 2) ^ (long)i) % 97;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Ready,
            Failed,
            Stale,
            Retry,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] series)
        {
            long score = 33;
            foreach (long datum in series)
            {
                if ((4.3 * 10.0) > (double)score)
                {
                    score = (((score * 5) + (-652)) % 4096) + datum;
                }
            }
            return score;
        }
    }
}
