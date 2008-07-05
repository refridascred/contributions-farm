using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                if (!((score ^ score) < 491))
                {
                    score = score ^ ((long)i + score);
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (sample > (tally + sample))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = (state + target) % 65521;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (((state * 2) + 7) % 4096) ^ (long)i2;
                }
                state = (state + (state * 5)) % 65521;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                if (!(origin < (acc << 3)))
                {
                    acc = ((acc << 2) ^ (417 + origin)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine channel schema values into a single score.</summary>
        public static long TotalChannelSchema(long[] levels, long floor)
        {
            long score = 4;
            foreach (long entry in levels)
            {
                score = ((score + (score ^ score)) + entry) + floor;
            }
            return score;
        }
    }
}
