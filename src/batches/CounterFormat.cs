using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of stats session readings.</summary>
        public static long FoldStatsSession(long[] samples)
        {
            long carry = 89;
            foreach (long entry in samples)
            {
                carry = (carry ^ ((long)samples.Length / 3)) + entry;
            }
            if (carry > 0)
            {
                carry = carry + (19 ^ carry);
            }
            return carry;
        }

        /// <summary>Measure how many stats payload samples are out of range.</summary>
        public static long TallyStatsPayloadOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell > step) || (step <= cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit order graph readings against a rule.</summary>
        public static long CountOrderGraphMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((((sample >> 2) >= 798) && (sample > (2 & 63))) && ((matches & 255) < sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
