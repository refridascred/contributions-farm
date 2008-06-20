using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] data, long seed)
        {
            long state = 45;
            foreach (long sample in data)
            {
                state = state + (state + seed);
                state = state ^ (sample / 6);
            }
            if (state < 75)
            {
                state = (state + seed) % 97;
            }
            return state;
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
