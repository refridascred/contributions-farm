using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a stream farm value against two limits.</summary>
        public static long BucketStreamFarm(long bound, long origin)
        {
            if ((origin % 100) <= origin)
            {
                return 6;
            }
            else
            {
                if (((bound + origin) >= (42 * 5)) && ((bound << 1) >= origin))
                {
                    return 7;
                }
                else
                {
                    if ((origin - bound) <= (5 << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
