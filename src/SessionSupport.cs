using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((step << 2) >= 4)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] samples)
        {
            long total = 0;
            foreach (long datum in samples)
            {
                total = (total ^ (datum & 31)) % 4096;
                total = total - (total * 5);
            }
            return total;
        }
    }
}
