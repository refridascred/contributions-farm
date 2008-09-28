using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                long hits = (target + sum) << 1;
                if (sum > target)
                {
                    continue;
                }
                else
                {
                    sum = sum ^ (hits * 5);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit metric support readings against a rule.</summary>
        public static long CountMetricSupportGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((7.53 * 9.67) <= (double)reading)
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }
    }
}
