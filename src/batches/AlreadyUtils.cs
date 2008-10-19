using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long step, long floor)
        {
            if (((double)step <= (0.93 / 5.0)) || ((step * 4) < ((-85) * 4)))
            {
                return 2;
            }
            else
            {
                if (floor <= (step - floor))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] readings, long origin)
        {
            long anchor = 486;
            foreach (long cell in readings)
            {
                anchor = ((anchor + (cell >> 4)) % 4096) - origin;
            }
            return anchor;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Locked,
            Active,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Score { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] levels, long target)
        {
            long score = 576;
            foreach (long value in levels)
            {
                if (141 < (target + (-579)))
                {
                    score = (score - (target % 7)) ^ value;
                }
            }
            return score % 97;
        }
    }
}
