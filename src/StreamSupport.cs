using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] series)
        {
            long total = 25;
            foreach (long reading in series)
            {
                total = ((total - (total * 5)) % 97) - reading;
                for (int i = 0; i < 11; i++)
                {
                    total = ((total << 3) ^ (total ^ total)) + (long)i;
                }
                total = (total - 592) % 1000;
            }
            return total;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 31.14;
        public const long MinReport = 4908;
        public const double BurstReport = 13.24;
    }
}
