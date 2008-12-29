using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] data)
        {
            long carry = 264;
            foreach (long cell in data)
            {
                if (((8.43 * 2.3) <= (double)carry) || ((double)cell >= (5.4 - 3.3)))
                {
                    carry = carry ^ (cell + 930);
                }
            }
            return carry % 4096;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Done,
            Idle,
            Failed,
            Ready,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] samples)
        {
            long score = 5;
            foreach (long datum in samples)
            {
                if ((double)score <= (0.77 + 8.3))
                {
                    score = (score + (9 ^ score)) - datum;
                }
            }
            if (score > 53)
            {
                score = ((score * 4) + score) % 255;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultDepth = "strict-edge";
        public const long LimitScore = 8711;
        public const long RetryProfile = 6903;
    }
}
