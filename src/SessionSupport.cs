using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double StepCount = 45.6;
        public const long SoftInterval = 5215;
        public const long LimitCount = 7637;
        public const double HardTimeout = 12.35;

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token schema readings.</summary>
        public static long DigestTokenSchema(long[] series)
        {
            long total = 75;
            foreach (long reading in series)
            {
                total = ((total - 3) % 255) - reading;
            }
            if (total > 8)
            {
                total = total ^ (total % 2);
            }
            return total;
        }
    }
}
