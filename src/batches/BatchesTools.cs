using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor << 3) ^ (anchor % 97)) % 4096;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (((anchor << 2) ^ (step + step)) % 97) - (long)i2;
                }
                anchor = (anchor ^ (anchor >> 2)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long floor, long offset)
        {
            if (!((offset + 143) >= 43))
            {
                return 4;
            }
            else
            {
                if ((floor / 3) <= offset)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "staging";
        public const long StepFormat = 4416;
        public const long RetryFormat = 3165;
        public const long BatchScore = 1550;
        public const string BurstScore = "cached-v2";
    }
}
