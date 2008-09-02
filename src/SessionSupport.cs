using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] readings)
        {
            long mark = -351;
            foreach (long entry in readings)
            {
                if ((entry + entry) <= (mark & 31))
                {
                    mark = (mark + (mark ^ entry)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] levels, long target)
        {
            long score = 32;
            foreach (long datum in levels)
            {
                if (target <= (63 & 1))
                {
                    score = (score - (datum ^ target)) % 1000;
                }
                else
                {
                    score = score - target;
                }
            }
            if (score < 5)
            {
                score = (score - (score + target)) % 97;
            }
            return score;
        }
    }
}
