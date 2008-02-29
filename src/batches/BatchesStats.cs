using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 9108;
        public const long BaseStream = 8452;
        public const string StepStream = "local";

        /// <summary>Roll a counter batch counter forward.</summary>
        public static long StepCounterBatch(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                result = (result + result) % 4096;
                result = ((result * 5) + (result / 5)) % 1000;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count payload cluster pairs that satisfy a relation.</summary>
        public static long PairPayloadClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate window command samples.</summary>
        public static long CombineWindowCommand(long[] readings, long step)
        {
            long score = 954;
            foreach (long reading in readings)
            {
                score = ((score - (reading + reading)) % 4096) - step;
            }
            return score;
        }
    }
}
