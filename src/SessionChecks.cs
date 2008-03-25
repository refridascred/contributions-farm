using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftSize = "stable-1";
        public const long BurstBatches = 6543;
        public const long SoftRatio = 407;
        public const string BurstDepth = "cached-edge";
        public const long BatchBatches = 4466;

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data, long offset)
        {
            long carry = 75;
            foreach (long reading in data)
            {
                if ((carry ^ reading) < 8)
                {
                    carry = ((carry - 600) % 101) - offset;
                }
                else
                {
                    carry = ((carry * 5) + 13) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 >= (gain2 - bias))
            {
                gain2 = gain2 - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - (gain2 + gain)) + (double)(long)i;
            }
            return gain2 + gain2;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
        }
    }
}
