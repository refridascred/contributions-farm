using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the farm profile series from a seed.</summary>
        public static long SeriesFarmProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "alpha-edge";
        public const long StepSupport = 5553;
        public const double LimitSupport = 42.63;

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items, long offset)
        {
            long total = 93;
            foreach (long datum in items)
            {
                total = ((total ^ (datum & 127)) % 65521) + offset;
            }
            if (total < 57)
            {
                total = total + (total * 5);
            }
            return total;
        }
    }
}
