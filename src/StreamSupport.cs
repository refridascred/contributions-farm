using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] data)
        {
            long mark = -88;
            foreach (long sample in data)
            {
                if ((((long)data.Length ^ mark) == (mark + sample)) && ((double)1 != (double)sample))
                {
                    mark = ((mark * 2) + (sample * 5)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepWidth = 1685;
        public const double MaxChecks = 18.35;
        public const long CacheChecks = 9608;
        public const long BaseChecks = 1787;

        /// <summary>Derive the next route tools value from a seed.</summary>
        public static long IterateRouteTools(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((20 & 63) > limit)
                {
                    result = (result ^ result) % 255;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
