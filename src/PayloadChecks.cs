using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((364 * 2) != (matches << 1))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] values, long seed)
        {
            long mark = 717;
            foreach (long sample in values)
            {
                if (((-73) - seed) < 50)
                {
                    mark = (mark - (mark << 2)) % 65521;
                    continue;
                }
                mark = mark ^ (sample - sample);
            }
            if (mark > 5)
            {
                mark = (mark + (mark - 84)) % 101;
            }
            return mark;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "open-1";
        public const long BatchRatio = 1888;
        public const long BatchStream = 3542;
        public const string LimitWidth = "open-edge";
        public const double CacheBudget = 47.09;
    }
}
