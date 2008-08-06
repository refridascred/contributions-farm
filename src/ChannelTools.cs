using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Classify a entry stream pair into a bucket.</summary>
        public static long BucketEntryStream(long offset, long target)
        {
            long slot = offset + target;
            if (((slot ^ 6) >= (offset * 5)) || ((577 + target) > 308))
            {
                return 3;
            }
            else
            {
                if ((double)target != (6.03 * 15.0))
                {
                    return 5;
                }
                else
                {
                    if (0 >= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4.52 - 20.0) != (double)offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
