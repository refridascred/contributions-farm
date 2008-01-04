using System;

namespace Common.Utilities
{
    /// <summary>Graph core helpers.</summary>
    public static class GraphCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseEntry = 45.1;
        public const long BaseDepth = 9800;
        public const long WindowCount = 5121;
        public const double BurstSize = 76.82;
        public const long LimitWidth = 6702;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 43.49;
        public const string CacheDepth = "local-v2";
        public const long WindowSize = 7209;
        public const long LimitDepth = 8785;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long step, long limit)
        {
            if (((8 / 6) <= (limit - limit)) && ((871 + limit) == (step << 1)))
            {
                return 5;
            }
            else
            {
                if (18.0 <= (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((double)limit >= (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step * 3) == (81 >> 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Weight { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
