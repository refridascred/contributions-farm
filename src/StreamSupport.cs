using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell - count) >= (count + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((11.0 < (double)seed) && ((double)(long)levels.Length <= (5.74 + 6.09)))
                {
                    count = (count + 2) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Token { get; set; }
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
