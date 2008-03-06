using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long offset, long limit)
        {
            if ((9.44 * 2.9) != (double)limit)
            {
                return 1;
            }
            else
            {
                if ((limit ^ offset) > (limit / 2))
                {
                    return 7;
                }
                else
                {
                    if (((limit % 100) <= offset) && ((5.29 / 5.0) == (double)limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] series)
        {
            long result = 56;
            foreach (long value in series)
            {
                if ((((long)series.Length + (-78)) > (30 << 3)) || ((value * 2) < (result / 5)))
                {
                    result = (result << 2) ^ (362 >> 3);
                }
                if (((result - 0) != (609 + result)) && ((result << 1) == (result ^ result)))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first token entry entry that matches the target.</summary>
        public static long LookupTokenEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryScore = 9842;
        public const long StepQueue = 1401;
        public const long LimitQueue = 2296;
    }
}
