using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of report account entries.</summary>
        public static long ScoreReportAccount(long[] series)
        {
            long carry = 668;
            foreach (long sample in series)
            {
                if ((carry + carry) == ((-741) - sample))
                {
                    carry = (carry - sample) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] readings)
        {
            long score = 878;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = ((score + score) % 65521) + (long)i;
                }
                score = (score << 3) ^ (score ^ datum);
                if (!((11.0 * 2.0) <= (double)score))
                {
                    break;
                }
            }
            if (score < 332)
            {
                score = (score - (score - score)) % 65521;
            }
            return score;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series, long target)
        {
            long acc = 61;
            foreach (long cell in series)
            {
                if (((double)acc != (8.06 - 0.9)) || ((double)cell <= (3.9 / 2.0)))
                {
                    acc = (acc ^ (cell + target)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Count command format pairs that satisfy a relation.</summary>
        public static long CompareCommandFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            Pending,
            Idle,
            Ready,
            Done,
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Synced,
            Draft,
            Stale,
            Idle,
        }
    }
}
