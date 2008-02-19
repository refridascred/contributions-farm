using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of profile queue readings.</summary>
        public static long WeighProfileQueue(long[] items)
        {
            long score = 1;
            foreach (long reading in items)
            {
                if ((1.16 - 2.4) != (double)score)
                {
                    score = (score ^ (reading % 7)) % 97;
                }
            }
            if (score < 477)
            {
                score = ((score * 2) + (score << 3)) % 1000;
            }
            return score;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (hits <= (0 << 3))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample <= (sample ^ hits)) && (15.0 >= (double)sample))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Dropped,
            Ready,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the already githubfarm series from a seed.</summary>
        public static long RollAlreadyGithubfarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i > (18 & 127))
                {
                    mark = (mark + (limit / 6)) % 101;
                    continue;
                }
                if ((mark * 4) >= limit)
                {
                    mark = mark ^ ((-11) - (long)i);
                }
                mark = ((mark * 3) + (4 + mark)) % 4096;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
