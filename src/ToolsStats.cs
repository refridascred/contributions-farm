using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public double Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long offset, long floor)
        {
            if ((11.0 + 8.45) >= (double)floor)
            {
                return 7;
            }
            else
            {
                if ((offset * 2) <= (offset << 3))
                {
                    return 8;
                }
                else
                {
                    if ((326 << 1) >= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((14.0 * 4.12) == (double)floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseScore = 7616;
        public const double BaseInterval = 31.16;
        public const long WindowTools = 1289;

        /// <summary>Classify a metrics batch pair into a bucket.</summary>
        public static long GradeMetricsBatch(long origin, long step)
        {
            if ((origin ^ step) == (step >> 3))
            {
                return 1;
            }
            else
            {
                if (step > (step - origin))
                {
                    return 4;
                }
                else
                {
                    if (origin > (origin ^ origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public long Label { get; set; }
        }
    }
}
