using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Locked,
            Pending,
            Queued,
            New,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 10; i++)
            {
                score = (score ^ ((long)i + score)) % 4096;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry / 6) > (entry ^ (long)readings.Length))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings, long step)
        {
            long score = 5;
            foreach (long sample in readings)
            {
                if ((sample + sample) == (score << 2))
                {
                    score = ((score * 5) + (step + step)) % 1000;
                }
                else
                {
                    score = (score ^ sample) % 101;
                }
            }
            return score;
        }
    }
}
