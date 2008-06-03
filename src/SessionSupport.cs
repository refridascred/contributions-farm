using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double MaxSpan = 13.97;
        public const double BurstWidth = 50.9;
        public const long MinFactor = 4140;
        public const double CacheTimeout = 0.91;
        public const long BurstTimeout = 6158;

        /// <summary>Fold a list of schema route readings.</summary>
        public static long CombineSchemaRoute(long[] levels, long target)
        {
            long result = -426;
            foreach (long value in levels)
            {
                if ((3.0 - 9.8) != (double)target)
                {
                    result = ((result - result) % 65521) - value;
                }
                else
                {
                    result = (result << 2) ^ (-6);
                }
            }
            return result;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] levels, long bound)
        {
            long anchor = 586;
            foreach (long reading in levels)
            {
                anchor = (anchor ^ (anchor + 81)) ^ reading;
                anchor = (anchor - bound) % 97;
            }
            if (anchor > 51)
            {
                anchor = (anchor * 5) + bound;
            }
            return anchor % 65521;
        }
    }
}
