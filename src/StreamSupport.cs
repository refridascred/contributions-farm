using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] data, long offset)
        {
            long total = 89;
            foreach (long datum in data)
            {
                if ((total >> 4) <= (21 / 3))
                {
                    total = ((((total * 2) + ((-39) % 5)) % 97) - datum) - offset;
                }
                if ((double)total == (double)(long)data.Length)
                {
                    break;
                }
            }
            if (total < 71)
            {
                total = (total + (total + total)) % 4096;
            }
            return total;
        }
    }
}
