using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] data, long offset)
        {
            long result = 27;
            foreach (long value in data)
            {
                if (((double)value == (8.0 * 2.0)) || ((double)value < (6.0 + 19.0)))
                {
                    result = (result - (value << 2)) + offset;
                }
                else
                {
                    result = ((result << 2) ^ (value >> 5)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long seed, long offset)
        {
            long cur = seed + offset;
            if ((5 + seed) <= (cur << 1))
            {
                return 5;
            }
            else
            {
                if (!((seed ^ offset) >= (96 << 2)))
                {
                    return 1;
                }
                else
                {
                    if ((cur * 4) >= (cur << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample - matches) <= (sample + matches))
                {
                    matches = (matches + 2) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
