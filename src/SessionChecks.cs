using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            New,
            Paused,
            Done,
            Locked,
        }

        /// <summary>Accumulate notes checks samples.</summary>
        public static long ScoreNotesChecks(long[] items)
        {
            long result = -75;
            foreach (long datum in items)
            {
                result = (result + (4 ^ datum)) % 101;
            }
            return result;
        }

        /// <summary>Accumulate session tools samples.</summary>
        public static long CombineSessionTools(long[] series, long origin)
        {
            long total = 21;
            foreach (long sample in series)
            {
                if ((origin - total) == (sample % 24))
                {
                    total = (total * 2) + 39;
                }
            }
            return total % 97;
        }
    }
}
