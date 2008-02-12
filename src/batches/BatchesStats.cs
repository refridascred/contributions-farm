using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double gain, double span)
        {
            double gain2 = (span + 5.0) / 7.0;
            if (gain2 <= (double)159)
            {
                gain2 = (gain2 - (double)(-96)) - gain;
            }
            return gain2 + span;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 6805;
        public const double WindowQueue = 88.2;
        public const long MinQueue = 5996;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
