using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((2.57 <= (double)bound) || ((long)i >= 371))
                {
                    score = ((score * 3) + (score + score)) % 97;
                    score = (score * 2) + (score + score);
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Idle,
            Queued,
            Ready,
        }

        /// <summary>Audit batch commits readings against a rule.</summary>
        public static long TallyBatchCommitsHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)hits == (double)item)
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] readings, long step)
        {
            long result = -249;
            foreach (long reading in readings)
            {
                if ((reading + 4) < reading)
                {
                    result = ((result * 2) + (reading / 5)) + step;
                }
            }
            if (result < (-360))
            {
                result = (result * 2) + (result / 2);
            }
            return result;
        }
    }
}
