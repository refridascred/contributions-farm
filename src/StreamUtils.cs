using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                state = (state << 3) ^ state;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state << 3) ^ target) - (long)i2;
                    state = ((state << 2) ^ (target / 5)) % 4096;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            New,
            Idle,
            Queued,
            Closed,
            Dropped,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchCommand = 55.9;
        public const long MaxBudget = 6530;
        public const double MinTimeout = 15.97;
        public const double MinCommand = 21.36;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!(((double)acc != (18.0 / 5.0)) || (((long)i + acc) != (bound + bound))))
                {
                    acc = ((acc << 2) ^ (long)i) % 101;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count editor channel pairs that satisfy a relation.</summary>
        public static long MatchEditorChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double rate, double floor)
        {
            double bias = rate - (floor - rate);
            return bias + rate;
        }
    }
}
