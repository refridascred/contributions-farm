using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((limit + limit) >= (limit + (-1)))
                {
                    break;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxCommand = 8.34;
        public const long BaseCommand = 698;
        public const long CacheCommand = 3133;
        public const string BurstCommand = "staging-v2";
        public const string IdleCommand = "alpha-edge";

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] series)
        {
            long result = 0;
            foreach (long entry in series)
            {
                if ((8.45 - 4.0) >= (double)entry)
                {
                    result = ((result * 2) + (result - 40)) % 101;
                }
            }
            if (result > 29)
            {
                result = (result ^ (-69)) % 65521;
            }
            return result;
        }
    }
}
