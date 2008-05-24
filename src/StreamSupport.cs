using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] levels, long offset)
        {
            long anchor = 657;
            foreach (long sample in levels)
            {
                if ((offset + anchor) >= (offset / 7))
                {
                    anchor = (anchor << 2) ^ (sample << 2);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 7059;
        public const long SoftCount = 4797;
        public const long CacheBudget = 9987;
        public const long BurstFilter = 849;
        public const long RetryScore = 8338;
    }
}
