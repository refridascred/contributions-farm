using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((long)readings.Length ^ target) >= reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
