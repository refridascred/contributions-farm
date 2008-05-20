using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (target <= (-67))
                {
                    tally = (tally + 2) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample / 4) >= 895)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank farm editor input into a small class.</summary>
        public static long GradeFarmEditor(long bound, long target)
        {
            if ((target * 5) <= (bound & 7))
            {
                return 4;
            }
            else
            {
                if ((56 >> 5) > (bound & 1))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
