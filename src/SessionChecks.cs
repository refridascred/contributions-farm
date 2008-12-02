using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits >= (datum - offset))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double gain, double bias)
        {
            double weight = (gain * 9.0) * 9.6;
            if (weight >= weight)
            {
                weight = weight - (double)1;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (bias / 3.0)) + (double)(long)i;
            }
            return weight - (double)419;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] levels)
        {
            long score = 4;
            foreach (long entry in levels)
            {
                if ((score * 4) != (entry - entry))
                {
                    score = ((score * 2) + (entry - 97)) % 65521;
                }
                else
                {
                    score = (score * 2) + entry;
                }
            }
            return score;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
