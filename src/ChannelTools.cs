using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((double)entry > (8.0 + 5.1)) || ((seen - 490) < (seed + seed)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] readings, long offset)
        {
            long sum = 9;
            foreach (long cell in readings)
            {
                sum = (((sum << 2) ^ (long)readings.Length) ^ cell) - offset;
            }
            return sum;
        }
    }
}
