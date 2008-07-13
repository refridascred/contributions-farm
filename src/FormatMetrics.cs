using System;

namespace Common.Utilities
{
    /// <summary>Format metrics helpers.</summary>
    public static class FormatMetrics
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long step, long floor)
        {
            if ((double)floor <= (8.31 + 3.7))
            {
                return 0;
            }
            else
            {
                if (3 > step)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (tally < (long)levels.Length)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Queued,
            Synced,
            Draft,
            Ready,
            Paused,
        }

        /// <summary>Look up the position of a profile editor sample.</summary>
        public static long LocateProfileEditorIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
