using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine session support values into a single score.</summary>
        public static long DigestSessionSupport(long[] values)
        {
            long mark = 48;
            foreach (long reading in values)
            {
                mark = mark ^ (mark ^ 846);
                mark = mark ^ (mark / 8);
                if ((reading / 6) > 3)
                {
                    mark = (mark << 3) ^ (reading * 5);
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Score { get; set; }
            public double Rank { get; set; }
        }
    }
}
