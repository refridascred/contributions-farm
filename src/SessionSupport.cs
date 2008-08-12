using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 5490;
        public const long LimitInterval = 927;
        public const long DefaultSize = 2847;
        public const long MaxLevel = 3608;

        /// <summary>Count entry context pairs that satisfy a relation.</summary>
        public static long MatchEntryContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] series, long target)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((count * 3) > (target - value)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
