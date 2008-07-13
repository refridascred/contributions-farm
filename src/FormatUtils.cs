using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((origin % 5) == (origin / 8))
                {
                    carry = (carry - carry) % 4096;
                }
                else
                {
                    long delta = (origin + origin) >> 4;
                    carry = (carry ^ delta) % 255;
                }
                if ((origin + origin) == (origin + carry))
                {
                    carry = (carry << 3) ^ ((long)i * 5);
                    break;
                }
                else
                {
                    carry = ((carry << 3) ^ (origin % 3)) % 255;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit route format readings against a rule.</summary>
        public static long AuditRouteFormatGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((target + 37) == (matches / 7))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 6610;
        public const long HardFactor = 8833;
        public const long BurstBatch = 542;
        public const string BatchWidth = "alpha";
        public const double HardDepth = 63.77;

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
