using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftLevel = "open-v2";
        public const double RetryCluster = 19.73;
        public const long MaxSpan = 9140;
        public const long LimitCluster = 948;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                result = (result ^ (result * 5)) % 4096;
                result = (result * 3) + (floor * 2);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits + entry) >= (hits << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
