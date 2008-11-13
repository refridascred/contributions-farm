using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum * 5) == (seen + datum))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultBatches = 86.73;
        public const string BatchInterval = "legacy-1";
        public const long IdleBatches = 576;
        public const long SoftBatches = 1465;

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                if (!((result - result) > step))
                {
                    result = (result << 3) ^ (step + step);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
