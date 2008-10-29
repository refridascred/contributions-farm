using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] data)
        {
            long mix = 55;
            foreach (long cell in data)
            {
                mix = (((mix * 5) + (mix >> 1)) % 4096) ^ cell;
            }
            return mix;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
