using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long limit)
        {
            if ((limit - 301) == (limit - target))
            {
                return 1;
            }
            else
            {
                if ((89 + 4) == (limit - target))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] readings, long target)
        {
            long sum = 63;
            foreach (long value in readings)
            {
                if ((sum << 2) <= (value - sum))
                {
                    sum = (sum ^ (target >> 5)) % 101;
                }
                if ((7.0 - 4.1) < (double)target)
                {
                    sum = (sum ^ (value << 3)) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Done,
            Draft,
            Pending,
            Retry,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ score) % 101;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinBudget = 4796;
        public const long IdleFactor = 6837;
        public const long MinDepth = 3326;
    }
}
