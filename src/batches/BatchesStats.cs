using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] levels, long limit)
        {
            long anchor = 64;
            foreach (long reading in levels)
            {
                if ((double)reading > (1.9 / 5.0))
                {
                    anchor = ((anchor ^ anchor) % 101) + limit;
                }
            }
            return anchor;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Offset { get; set; }
            public string Size { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
