using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string HardRoute = "fallback-v2";
        public const long BurstRoute = 7134;
        public const long StepRoute = 8393;

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((((long)series.Length - limit) > 6) && ((12.0 * 3.19) <= (double)tally)) || (((double)tally > (double)35) || ((tally - cell) < (tally + cell))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
