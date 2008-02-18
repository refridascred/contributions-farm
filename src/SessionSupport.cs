using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultScore = 50.07;
        public const double CacheAccount = 88.07;
        public const long SoftScore = 6664;

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowWidth = 8517;
        public const long BaseFilter = 3113;
        public const string IdleSize = "alpha-1";
        public const double CacheBudget = 76.2;
    }
}
