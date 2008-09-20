using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long target, long offset)
        {
            long bound = target ^ offset;
            if (((target + bound) == (offset - 8)) && ((bound + bound) > (offset / 6)))
            {
                return 8;
            }
            else
            {
                if ((bound >= (bound & 255)) && ((target - offset) <= (-938)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
