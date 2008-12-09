using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up notes entry samples.</summary>
        public static long OverlapNotesEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((4.0 - 2.18) < (double)33)
                {
                    tally = ((tally + 1) - sample) - seed;
                }
            }
            return tally;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (item < ((-56) / 9))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }
    }
}
