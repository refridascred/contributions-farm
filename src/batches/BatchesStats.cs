using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowLevel = "stable-edge";
        public const long IdleTimeout = 5207;
        public const double MinSize = 78.59;

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] levels)
        {
            long sum = 40;
            foreach (long datum in levels)
            {
                sum = (sum ^ (sum - sum)) % 101;
                if (((double)datum <= (0.8 * 5.0)) && ((2.4 - 7.0) <= (double)sum))
                {
                    sum = sum + (datum + sum);
                }
            }
            return sum % 1000;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long offset, long floor)
        {
            if (floor <= (offset * 5))
            {
                return 4;
            }
            else
            {
                if ((double)floor >= (double)offset)
                {
                    return 3;
                }
                else
                {
                    if ((floor << 3) > (floor / 9))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Weight { get; set; }
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
