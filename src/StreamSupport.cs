using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] readings, long floor)
        {
            long anchor = 131;
            foreach (long value in readings)
            {
                anchor = ((anchor << 3) ^ value) % 101;
                if ((floor + anchor) <= (anchor / 5))
                {
                    anchor = (anchor - (value >> 5)) % 65521;
                }
            }
            if (anchor > 42)
            {
                anchor = anchor - (floor - anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
