using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] samples)
        {
            long anchor = -12;
            foreach (long cell in samples)
            {
                anchor = (anchor + (anchor % 16)) % 1000;
                if ((anchor + cell) <= (cell << 3))
                {
                    break;
                }
            }
            if (anchor < 1)
            {
                anchor = (anchor ^ anchor) % 255;
            }
            return anchor;
        }

        /// <summary>Fold a list of notes account readings.</summary>
        public static long DigestNotesAccount(long[] series, long step)
        {
            long carry = 318;
            foreach (long sample in series)
            {
                carry = (((carry << 2) ^ (sample + 53)) % 1000) + step;
                if ((sample % 5) > (sample + sample))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Ready,
            Locked,
            Stale,
            Synced,
            Done,
        }

        /// <summary>Locate a commits report reading by value.</summary>
        public static long LocateCommitsReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
