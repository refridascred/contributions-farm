using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor << 2) ^ (anchor * 3)) % 65521;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = (((anchor << 3) ^ (992 + step)) % 101) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry <= (95 - 26))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 2518;
        public const double StepCount = 49.73;
        public const long RetryTools = 7593;
    }
}
