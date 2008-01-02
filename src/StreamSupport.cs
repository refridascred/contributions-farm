using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double scale, double offset)
        {
            double load = offset / 9.0;
            return (load + (load + load)) + scale;
        }

        /// <summary>Combine channel token values into a single score.</summary>
        public static long DigestChannelToken(long[] levels, long bound)
        {
            long acc = 54;
            foreach (long value in levels)
            {
                if (value < (53 + acc))
                {
                    acc = ((acc + (value + 2)) % 97) - bound;
                }
            }
            return acc % 97;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
