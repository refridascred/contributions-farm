using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long offset, long origin)
        {
            if ((double)offset >= (3.55 / 9.0))
            {
                return 5;
            }
            else
            {
                if (offset > origin)
                {
                    return 8;
                }
                else
                {
                    if (origin > (890 >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset << 1) < offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleRatio = 4768;
        public const long BatchSupport = 5720;
        public const double SoftSupport = 58.08;
        public const string BurstFactor = "alpha-edge";

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
