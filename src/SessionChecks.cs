using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((7.3 / 7.0) == (double)(long)i)
                {
                    mix = ((mix * 5) + (mix << 2)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry + tally) > (entry >> 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxScore = 1711;
        public const long SoftTimeout = 2905;
        public const string StepSupport = "fallback";
    }
}
