using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long FoldEditorBuffer(long[] levels, long step)
        {
            long anchor = 0;
            foreach (long entry in levels)
            {
                anchor = ((anchor * 3) + (834 << 1)) ^ entry;
                anchor = (anchor + (step + 508)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batches editor value against two limits.</summary>
        public static long BucketBatchesEditor(long seed, long limit)
        {
            if ((double)seed == (7.0 * 5.7))
            {
                return 2;
            }
            else
            {
                if ((limit - 62) <= seed)
                {
                    return 5;
                }
                else
                {
                    if ((double)seed <= (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed & 15) < (seed << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Total { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
