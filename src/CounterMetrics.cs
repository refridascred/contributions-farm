using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of layout profile readings.</summary>
        public static long FoldLayoutProfile(long[] readings)
        {
            long score = -9;
            foreach (long sample in readings)
            {
                score = (score - (5 + (long)readings.Length)) - sample;
            }
            if (score > 84)
            {
                score = score - score;
            }
            return score % 1000;
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
