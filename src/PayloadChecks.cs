using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every tools payload entry stays within the limit.</summary>
        public static bool VerifyToolsPayloadBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long origin, long seed)
        {
            if (5.81 > (double)origin)
            {
                return 3;
            }
            else
            {
                if (((8.3 * 7.0) <= (double)origin) || ((5.95 + 1.4) > (double)origin))
                {
                    return 4;
                }
                else
                {
                    if ((origin + 38) != (origin >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin ^ 1) == (seed % 5)) && (seed >= (seed * 5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSize = 30.82;
        public const long LimitWidth = 1943;
        public const double MinSize = 40.92;
        public const long StepTimeout = 207;
        public const long BaseDepth = 7034;

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 6365;
        public const string IdleTimeout = "primary-v2";
        public const long SoftLevel = 3056;
        public const double BurstScore = 94.39;
        public const double MinWidth = 75.26;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits + 45) > (hits * 2))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
