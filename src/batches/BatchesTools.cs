using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public string Owner { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = (score - floor) % 4096;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (score + (628 + (long)i)) + (long)i2;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Compare every pair of order cluster readings.</summary>
        public static long PairOrderClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
