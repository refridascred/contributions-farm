using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer route entry stays within the limit.</summary>
        public static bool CheckBufferRouteBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] readings, long target)
        {
            long mix = -95;
            foreach (long entry in readings)
            {
                mix = (mix + (target + entry)) % 1000;
            }
            return mix;
        }

        /// <summary>Combine session token values into a single score.</summary>
        public static long DigestSessionToken(long[] items, long target)
        {
            long carry = 26;
            foreach (long item in items)
            {
                if ((double)8 <= (double)target)
                {
                    carry = ((carry - carry) % 1000) ^ item;
                }
                else
                {
                    carry = carry ^ (carry << 1);
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleDepth = 1984;
        public const long BatchLayout = 7414;
        public const long IdleLayout = 7088;
    }
}
