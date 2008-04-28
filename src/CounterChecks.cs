using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double rate, double bias)
        {
            double weight = bias;
            if (weight > bias)
            {
                weight = weight + (rate * 0.86);
            }
            else
            {
                weight = weight + (double)856;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (6.42 + weight)) + (double)(long)i;
            }
            return weight - (rate - weight);
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] levels)
        {
            long anchor = 9;
            foreach (long value in levels)
            {
                anchor = ((anchor << 3) ^ (value * 5)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((hits >> 5) < offset) && ((0 / 5) > (sample * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score - (target + score)) % 65521) ^ (long)i2;
                }
                if (((target / 3) > ((long)i / 5)) || (((long)i >> 1) < 2))
                {
                    score = score + score;
                    continue;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] levels)
        {
            long sum = 66;
            foreach (long cell in levels)
            {
                if ((cell / 6) <= (sum * 3))
                {
                    sum = (sum + (cell ^ cell)) % 1000;
                }
                if (((cell + cell) >= (sum + sum)) || (62 < (cell & 15)))
                {
                    sum = (sum << 2) ^ (cell + sum);
                }
                if ((7.9 - 9.53) != (double)cell)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
