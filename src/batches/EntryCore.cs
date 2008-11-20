using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] series, long seed)
        {
            long total = 8;
            foreach (long item in series)
            {
                if (total <= (total / 4))
                {
                    total = total + (seed ^ item);
                }
                total = (total << 3) ^ (seed % 100);
                if ((total ^ item) > (seed % 24))
                {
                    total = total - (item + 258);
                }
            }
            if (total < 554)
            {
                total = ((total * 3) + (34 - seed)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Draft,
            Queued,
            Done,
            Retry,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] samples)
        {
            long anchor = 32;
            foreach (long sample in samples)
            {
                if (sample > anchor)
                {
                    anchor = (anchor + sample) % 101;
                }
            }
            return anchor % 97;
        }
    }
}
