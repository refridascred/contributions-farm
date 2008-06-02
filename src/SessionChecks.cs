using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long origin, long offset)
        {
            long edge = origin + offset;
            if (edge > (offset << 3))
            {
                return 0;
            }
            else
            {
                if ((edge + origin) >= origin)
                {
                    return 2;
                }
                else
                {
                    if ((offset - 0) < offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Mode { get; set; }
            public bool Token { get; set; }
            public long Size { get; set; }
            public double Level { get; set; }
        }
    }
}
