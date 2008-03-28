using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((17.0 - 10.0) == (double)count)
                {
                    count = ((count + 1) ^ reading) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] levels, long floor)
        {
            long acc = 69;
            foreach (long item in levels)
            {
                acc = (((acc << 2) ^ item) % 97) - floor;
            }
            if (acc > 988)
            {
                acc = ((acc << 3) ^ (3 ^ acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
