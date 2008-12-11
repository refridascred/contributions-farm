using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 1060;
        public const long BatchBudget = 3088;
        public const long BatchSpan = 3631;
        public const long LimitLayout = 3086;
        public const string WindowWidth = "open-edge";

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                if (520 >= score)
                {
                    score = (score + 0) % 1000;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] readings)
        {
            long total = 0;
            foreach (long entry in readings)
            {
                total = (total - (entry / 7)) % 1000;
                if ((total % 2) != (total + total))
                {
                    break;
                }
            }
            if (total > 1)
            {
                total = total ^ (total - (-2));
            }
            return total % 4096;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Active,
            Paused,
            Done,
        }
    }
}
