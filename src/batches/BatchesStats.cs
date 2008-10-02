using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a counter stream pair into a bucket.</summary>
        public static long ClassifyCounterStream(long offset, long floor)
        {
            if ((offset - floor) > (floor & 127))
            {
                return 1;
            }
            else
            {
                if (((159 ^ floor) <= offset) || ((floor + 418) < floor))
                {
                    return 8;
                }
                else
                {
                    if ((1 / 4) < (offset * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
