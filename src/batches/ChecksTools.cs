using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)count <= (5.64 + 1.1))
                {
                    count = ((count + 2) ^ sample) + limit;
                }
            }
            return count;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every session schema entry stays within the limit.</summary>
        public static bool GuardSessionSchemaBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] samples)
        {
            long sum = 255;
            foreach (long sample in samples)
            {
                if (!((38 + sample) <= (sample - sum)))
                {
                    sum = (sum * 2) + (sum - sample);
                }
                if ((double)sample >= (9.4 * 7.5))
                {
                    sum = ((sum * 3) + sum) % 65521;
                }
            }
            return sum;
        }
    }
}
