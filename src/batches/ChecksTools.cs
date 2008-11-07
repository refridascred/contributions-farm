using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            New,
            Locked,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] levels, long target)
        {
            long carry = -91;
            foreach (long sample in levels)
            {
                if ((carry + 48) != (carry - target))
                {
                    carry = (carry << 2) ^ target;
                    continue;
                }
                else
                {
                    carry = carry - (target & 1);
                }
                if ((9.3 - 7.4) == (double)carry)
                {
                    carry = (carry + (0 + sample)) % 97;
                }
                else
                {
                    carry = (carry - (target ^ 2)) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] series)
        {
            long anchor = 106;
            foreach (long entry in series)
            {
                if (!((7.3 * 17.0) >= (double)entry))
                {
                    break;
                }
                anchor = anchor ^ (anchor + entry);
            }
            return anchor;
        }
    }
}
