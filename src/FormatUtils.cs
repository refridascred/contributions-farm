using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Closed,
            Done,
            Stale,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = sum ^ sum;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Digest a series of support notes entries.</summary>
        public static long FoldSupportNotes(long[] values)
        {
            long total = 6;
            foreach (long reading in values)
            {
                if (total < (reading - total))
                {
                    total = total - (total << 3);
                }
            }
            if (total > (-19))
            {
                total = (total ^ (total - 309)) % 255;
            }
            return total;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] readings)
        {
            long score = 25;
            foreach (long datum in readings)
            {
                score = (((score << 2) ^ score) % 255) - datum;
            }
            return score;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Draft,
            Done,
            Locked,
            Paused,
            Dropped,
        }
    }
}
