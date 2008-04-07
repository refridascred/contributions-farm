using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long offset, long offset2)
        {
            long step = offset - offset2;
            if ((offset - offset) >= offset2)
            {
                return 8;
            }
            else
            {
                if (77 >= (step * 5))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowFactor = 9463;
        public const long CacheCommand = 4038;
        public const long LimitCommand = 5084;

        /// <summary>Locate a context filter reading by value.</summary>
        public static long SeekContextFilterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum & 15) >= (datum - datum))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
