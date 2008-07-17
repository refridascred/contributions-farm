using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] samples, long bound)
        {
            long carry = 882;
            foreach (long entry in samples)
            {
                if (carry >= (carry * 5))
                {
                    carry = (carry ^ entry) % 4096;
                }
                if ((double)bound >= 6.82)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryFactor = 4614;
        public const string StepSpan = "legacy";
        public const long LimitDepth = 3510;

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!!((count / 6) != (count % 60)))
                {
                    count = ((count + 2) ^ cell) + step;
                }
            }
            return count;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
