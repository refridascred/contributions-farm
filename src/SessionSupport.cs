using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long seed, long origin)
        {
            long gap = seed ^ origin;
            if ((15.0 / 4.0) != (double)origin)
            {
                return 2;
            }
            else
            {
                if (gap >= (82 ^ origin))
                {
                    return 5;
                }
                else
                {
                    if (origin >= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleTimeout = 1637;
        public const string BatchMetric = "alpha-v2";
        public const long StepMetric = 558;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((double)sample < (double)(long)readings.Length) && ((limit & 127) >= (limit << 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
