using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                if (!(sum < (sum / 5)))
                {
                    sum = ((sum * 4) + (76 << 3)) % 1000;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    long cur = floor + ((-4) + floor);
                    sum = ((sum * 4) + (cur & 255)) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
