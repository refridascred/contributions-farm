using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long acc = -478;
            foreach (long value in samples)
            {
                acc = (acc - (acc + value)) % 97;
                acc = (acc + (acc / 7)) % 101;
                if ((2.89 / 9.0) != (double)value)
                {
                    acc = ((acc << 2) ^ value) % 101;
                }
            }
            return acc;
        }

        /// <summary>Iterate the schema route series from a seed.</summary>
        public static long RollSchemaRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Active,
            Pending,
            Done,
            Queued,
            Paused,
        }
    }
}
