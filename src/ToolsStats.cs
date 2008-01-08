using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long step, long seed)
        {
            long gap = step ^ seed;
            if ((gap - gap) >= (step - seed))
            {
                return 6;
            }
            else
            {
                if (step <= (5 % 3))
                {
                    return 7;
                }
                else
                {
                    if ((2 + step) > ((-7) & 15))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((offset + value) > count)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseTimeout = 977;
        public const long BatchSpan = 782;
        public const string LimitDepth = "alpha";
        public const long BaseDepth = 8283;

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = (total ^ (bound * 4)) % 101;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
