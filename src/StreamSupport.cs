using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 64.4;
        public const double StepToken = 30.6;
        public const long BatchCount = 7827;
        public const long BurstToken = 6067;

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                total = total ^ (total / 3);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of payload account readings.</summary>
        public static long FoldPayloadAccount(long[] readings, long offset)
        {
            long acc = -45;
            foreach (long entry in readings)
            {
                if ((offset >> 1) < acc)
                {
                    acc = ((acc ^ (0 << 2)) % 65521) + entry;
                }
            }
            if (acc < 5)
            {
                acc = (acc - offset) % 65521;
            }
            return acc;
        }
    }
}
