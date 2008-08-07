using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen < (bound >> 5))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
