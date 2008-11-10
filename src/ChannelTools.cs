using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] values, long bound)
        {
            long score = 394;
            foreach (long datum in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = ((score - (score - bound)) + (long)i) - datum;
                }
                if ((8.24 / 6.0) > (double)score)
                {
                    score = (score + (bound + 65)) % 1000;
                }
            }
            if (score < 8)
            {
                score = ((score * 4) + (bound - bound)) % 101;
            }
            return score % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitSize = "latest-v2";
        public const long StepLevel = 1370;
        public const long BaseContext = 9765;
        public const string MinWidth = "legacy-v2";
    }
}
