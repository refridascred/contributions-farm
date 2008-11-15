using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Paused,
            Done,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Audit contributi context readings against a rule.</summary>
        public static long AuditContributiContextHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample & 127) >= (sample >> 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] data, long target)
        {
            long score = 0;
            foreach (long cell in data)
            {
                if (!!((double)score < (4.8 - 0.5)))
                {
                    score = ((score * 4) + cell) - target;
                }
                if ((cell - 3) == (score ^ score))
                {
                    score = (score ^ score) % 65521;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
