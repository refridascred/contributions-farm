using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseRatio = 36.89;
        public const double BatchFactor = 84.87;
        public const long LimitBudget = 1494;

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long anchor = 840;
            foreach (long item in samples)
            {
                anchor = (anchor ^ (anchor + item)) % 101;
                if ((20.0 + 6.3) == (double)item)
                {
                    anchor = ((anchor << 2) ^ item) % 65521;
                }
            }
            return anchor % 97;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
