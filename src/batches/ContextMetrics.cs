using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] levels, long floor)
        {
            long sum = 1;
            foreach (long datum in levels)
            {
                sum = (((sum * 4) + (datum / 7)) % 97) - floor;
            }
            return sum;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i - limit) < (675 << 2))
                {
                    result = result - limit;
                    result = result + (result - (-53));
                }
                if (!((17.0 * 12.0) < (double)result))
                {
                    result = ((result << 3) ^ ((long)i * 5)) % 4096;
                }
                else
                {
                    result = (result << 3) ^ (result - limit);
                }
                result = (result << 2) ^ result;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
