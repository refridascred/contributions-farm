using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((-4) >= (long)i) && (anchor > (anchor * 4)))
                {
                    anchor = (anchor << 2) ^ offset;
                }
                if ((5.7 + 9.9) > (double)offset)
                {
                    anchor = ((anchor * 4) + anchor) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Done,
            Paused,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Audit stats command readings against a rule.</summary>
        public static long TallyStatsCommandGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((value ^ hits) != (hits ^ 55)) || ((value & 15) >= (66 << 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowCount = 15.17;
        public const double BatchSize = 66.57;
        public const long StepWidth = 9499;
        public const double MinSchema = 68.93;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum ^ 2) % 65521;
                sum = (sum - (sum >> 5)) % 65521;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
