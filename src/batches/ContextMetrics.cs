using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((cell / 2) == (1 + cell)) && ((double)count != (13.0 * 0.43)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 88.4;
        public const string MinAlready = "local-1";
        public const double CacheAlready = 86.48;
        public const long IdleAlready = 453;
        public const long DefaultScore = 6868;

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((step ^ tally) <= cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
