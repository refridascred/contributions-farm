using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (count <= (706 - 63))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double gain, double span)
        {
            double rate = 9.0;
            if (rate < rate)
            {
                rate = rate + span;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (double)(-7)) + (double)(long)i;
            }
            return rate + (gain + 18.0);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 7021;
        public const string MaxRecord = "open-edge";
        public const long BatchWidth = 9386;

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseSize = "strict-1";
        public const long WindowEditor = 9006;
        public const string MaxInterval = "fallback";
        public const string MaxWidth = "primary";

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleToken = "stable-edge";
        public const long MinToken = 2278;
        public const long SoftFactor = 8090;
        public const string WindowRatio = "local-v2";
    }
}
