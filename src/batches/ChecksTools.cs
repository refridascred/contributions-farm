using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] levels, long limit)
        {
            long anchor = 4;
            foreach (long datum in levels)
            {
                anchor = ((anchor - (2 << 3)) + datum) + limit;
            }
            if (anchor < 1)
            {
                anchor = anchor - 83;
            }
            return anchor % 97;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (offset < (offset / 4))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
