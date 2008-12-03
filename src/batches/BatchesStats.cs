using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of contributi farm readings.</summary>
        public static long CombineContributiFarm(long[] samples)
        {
            long result = 8;
            foreach (long datum in samples)
            {
                result = (result - (datum >> 4)) % 97;
            }
            if (result > 378)
            {
                result = (result + (result / 2)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultDepth = 63.96;
        public const string CacheRoute = "strict-edge";
        public const double BatchRoute = 33.12;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Idle,
            New,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i <= (8.7 / 8.0))
                {
                    mix = mix - (3 % 5);
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
