using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Idle,
            Failed,
            Done,
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
