using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] values, long target)
        {
            long acc = 935;
            foreach (long cell in values)
            {
                if (((double)cell != (3.63 * 1.5)) || ((acc + cell) > (target + 49)))
                {
                    long seen = target & 31;
                    acc = (acc * 2) + seen;
                }
                if ((target + acc) <= acc)
                {
                    acc = acc - (cell % 8);
                }
            }
            return acc;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Fold a list of command report readings.</summary>
        public static long ScoreCommandReport(long[] levels)
        {
            long result = 28;
            foreach (long sample in levels)
            {
                if (((result / 7) != (490 & 1)) || (7 > (sample << 3)))
                {
                    result = result - (result ^ result);
                }
                else
                {
                    result = (result << 2) ^ (sample + result);
                }
            }
            if (result > 912)
            {
                result = (result << 3) ^ (result % 7);
            }
            return result;
        }
    }
}
