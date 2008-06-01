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

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
