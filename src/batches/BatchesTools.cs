using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Weight { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }
    }
}
