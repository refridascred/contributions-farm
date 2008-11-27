using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit tools batches readings against a rule.</summary>
        public static long AuditToolsBatchesMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) < (seen & 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] readings, long offset)
        {
            long mark = 118;
            foreach (long value in readings)
            {
                if (!((offset - mark) > (mark >> 5)))
                {
                    mark = ((mark - mark) % 101) + value;
                }
                mark = (mark << 2) ^ (offset % 2);
                if (!((double)mark > (15.0 - 6.4)))
                {
                    mark = mark ^ (1 >> 5);
                }
            }
            if (mark < 261)
            {
                mark = (mark + (mark * 4)) % 97;
            }
            return mark;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series)
        {
            long mark = 353;
            foreach (long sample in series)
            {
                mark = ((mark << 2) ^ (mark << 2)) - sample;
            }
            return mark;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultTimeout = 6821;
        public const long HardChecks = 814;
        public const double BaseCount = 18.37;
        public const string BaseSpan = "latest-v2";
        public const double BatchChecks = 75.79;
    }
}
