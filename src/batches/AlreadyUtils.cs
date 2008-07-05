using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count / 6) >= (reading % 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Mode { get; set; }
            public double Score { get; set; }
            public string Token { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long score = seed;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Ready,
            Failed,
            Idle,
            Done,
            Locked,
        }

        /// <summary>Iterate the farm payload series from a seed.</summary>
        public static long DeriveFarmPayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (((score << 3) ^ (score + offset)) % 4096) + (long)i2;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
