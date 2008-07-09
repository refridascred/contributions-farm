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

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] data)
        {
            long acc = 96;
            foreach (long reading in data)
            {
                acc = ((acc * 5) + (acc + reading)) % 255;
            }
            if (acc > 348)
            {
                acc = (acc - (acc % 24)) % 4096;
            }
            return acc % 65521;
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
