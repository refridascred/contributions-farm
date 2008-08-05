using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] series)
        {
            long sum = -810;
            foreach (long cell in series)
            {
                if (((long)series.Length < cell) && ((916 ^ 779) < cell))
                {
                    sum = ((sum << 3) ^ (cell & 255)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the batch token entries that pass the check.</summary>
        public static long MeasureBatchTokenHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((seed - 77) < (value / 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
