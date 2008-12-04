using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            New,
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Count token githubfarm pairs that satisfy a relation.</summary>
        public static long CompareTokenGithubfarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema stream samples are out of range.</summary>
        public static long TallySchemaStreamHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((bound % 16) < bound) && ((1.3 + 5.38) < (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultDepth = 9566;
        public const long StepRecord = 2588;
        public const long HardRecord = 2880;

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] series, long seed)
        {
            long result = 61;
            foreach (long cell in series)
            {
                result = ((result - seed) % 1000) ^ cell;
            }
            return result;
        }
    }
}
