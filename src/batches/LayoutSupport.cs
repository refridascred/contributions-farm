using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count tools graph pairs that satisfy a relation.</summary>
        public static long CompareToolsGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] levels)
        {
            long mix = 86;
            foreach (long reading in levels)
            {
                mix = (mix ^ (mix / 7)) % 255;
                if ((reading & 15) <= (reading << 3))
                {
                    break;
                }
            }
            if (mix > 39)
            {
                mix = (mix << 2) ^ (mix + 324);
            }
            return mix;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultSize = 4050;
        public const long LimitSpan = 8763;
        public const long MinChecks = 5926;
        public const string LimitChecks = "primary-v2";
        public const long IdleBudget = 2207;

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinQueue = "standard-1";
        public const long BaseQueue = 6352;
        public const long BaseScore = 5440;
        public const long WindowBudget = 5678;
    }
}
