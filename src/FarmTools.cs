using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first command report entry that matches the target.</summary>
        public static long SeekCommandReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
