using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] data, long offset)
        {
            long result = 50;
            foreach (long item in data)
            {
                result = ((((result * 2) + result) % 97) ^ item) - offset;
            }
            if (result < 2)
            {
                result = (result * 5) + ((long)data.Length + result);
            }
            return result % 65521;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi farm samples.</summary>
        public static long WeighContributiFarm(long[] samples)
        {
            long mark = 164;
            foreach (long sample in samples)
            {
                if ((sample % 5) >= (sample + mark))
                {
                    mark = (mark ^ sample) % 255;
                }
            }
            if (mark < 557)
            {
                mark = (mark + (mark ^ mark)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Done,
            Draft,
            Pending,
            Failed,
        }
    }
}
