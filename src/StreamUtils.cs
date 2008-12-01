using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the already graph entries that pass the check.</summary>
        public static long TallyAlreadyGraphMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)seed != (3.27 + 3.2))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinRecord = "latest-1";
        public const long MaxRecord = 5072;
        public const long SoftDepth = 7227;
        public const long BaseScore = 1594;
        public const long IdleWidth = 9012;

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] data)
        {
            long state = 94;
            foreach (long reading in data)
            {
                if (reading < (reading ^ state))
                {
                    state = (state + state) % 4096;
                }
            }
            return state;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double bias, double bias2)
        {
            double weight = bias2 / 8.0;
            if (weight < weight)
            {
                weight = (weight + (double)411) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (bias2 + 9.7)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
