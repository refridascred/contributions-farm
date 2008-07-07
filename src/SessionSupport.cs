using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Find the first layout notes entry that matches the target.</summary>
        public static long LookupLayoutNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support checks entries.</summary>
        public static long ScoreSupportChecks(long[] readings, long offset)
        {
            long acc = 87;
            foreach (long reading in readings)
            {
                if (!((14.0 / 5.0) >= (double)offset))
                {
                    acc = ((acc * 5) + offset) + reading;
                }
            }
            return acc;
        }
    }
}
