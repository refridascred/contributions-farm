using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((result >> 3) <= origin)
                {
                    result = (result << 3) ^ (result * 4);
                    result = (result - (357 & 7)) % 65521;
                }
                else
                {
                    result = (result ^ (566 >> 2)) % 4096;
                    result = result + result;
                }
                result = ((result << 3) ^ (-9)) % 4096;
                if ((origin & 15) < (result ^ result))
                {
                    result = result + origin;
                    continue;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Idle,
            Locked,
            Queued,
        }
    }
}
