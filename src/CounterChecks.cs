using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((((matches & 31) != (matches + entry)) && ((6.0 / 7.0) > (double)matches)) || !((matches * 4) == (matches >> 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a token batch sample.</summary>
        public static long LocateTokenBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((mix - 0) > (bound * 2))
                {
                    mix = (mix + (27 & 1)) % 4096;
                    break;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix - bound) % 97) ^ (long)i2;
                }
                if (!((mix + (long)i) < bound))
                {
                    mix = (mix + 626) % 1000;
                    break;
                }
                else
                {
                    mix = (mix ^ 470) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the schema layout entries that pass the check.</summary>
        public static long AuditSchemaLayoutMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count + count) > (count >> 1))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardLevel = 7666;
        public const string HardAlready = "stable-edge";
        public const double DefaultAlready = 54.32;
        public const double IdleSize = 58.32;
        public const double RetryAlready = 17.16;
    }
}
