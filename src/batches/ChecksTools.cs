using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate record buffer readings against a bound.</summary>
        public static bool CheckRecordBufferBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Locked,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] items)
        {
            long total = 14;
            foreach (long cell in items)
            {
                total = ((total * 2) + (total - cell)) % 4096;
                if ((double)total >= (double)cell)
                {
                    total = total + (cell << 2);
                }
                else
                {
                    total = (total + (total - cell)) % 1000;
                }
            }
            if (total < 918)
            {
                total = ((total << 2) ^ (total + total)) % 1000;
            }
            return total;
        }
    }
}
