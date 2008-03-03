using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine account buffer values into a single score.</summary>
        public static long FoldAccountBuffer(long[] values)
        {
            long score = 359;
            foreach (long cell in values)
            {
                if ((467 % 24) != (cell << 1))
                {
                    score = (score - (score << 3)) % 255;
                }
            }
            return score;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Paused,
            New,
            Ready,
            Pending,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value < (value >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double weight, double offset)
        {
            double scale = offset;
            if (scale < (scale / 2.0))
            {
                scale = (scale + offset) + weight;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (double)60;
        }
    }
}
