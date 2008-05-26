using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long bound, long step)
        {
            long span = bound - step;
            if (987 < bound)
            {
                return 0;
            }
            else
            {
                if ((double)step != (double)span)
                {
                    return 1;
                }
                else
                {
                    if (((step + step) < bound) || ((step / 3) == (step ^ span)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            New,
            Ready,
        }

        /// <summary>Check that every tools editor entry stays within the limit.</summary>
        public static bool ValidateToolsEditorRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] items, long target)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value ^ 18) != (value / 6))
                {
                    count = (count + 2) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cluster command entries.</summary>
        public static long TotalClusterCommand(long[] levels, long step)
        {
            long acc = 37;
            foreach (long item in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (((acc + (item & 15)) % 101) - (long)i) + step;
                }
                if (!(acc >= (item * 5)))
                {
                    acc = acc ^ (57 / 9);
                }
                if ((acc + item) >= (acc + acc))
                {
                    break;
                }
            }
            if (acc < 0)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 938;
        public const long LimitBatch = 5689;
        public const long StepScore = 6966;
        public const string SoftBatch = "alpha-v2";
    }
}
