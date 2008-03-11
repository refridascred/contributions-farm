using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long origin, long offset)
        {
            if ((offset / 6) < origin)
            {
                return 4;
            }
            else
            {
                if (((double)offset <= 2.34) || ((double)offset == (double)origin))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
