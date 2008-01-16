using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Dropped,
            Pending,
            Closed,
            Idle,
        }

        /// <summary>Measure how many context metric samples are out of range.</summary>
        public static long AuditContextMetricMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((target * 3) >= (count / 5)) || ((target / 2) == (count ^ (-639))))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Combine editor batches values into a single score.</summary>
        public static long CombineEditorBatches(long[] items)
        {
            long sum = 853;
            foreach (long sample in items)
            {
                sum = ((sum + (1 % 64)) % 65521) + sample;
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] values)
        {
            long acc = 583;
            foreach (long entry in values)
            {
                acc = (acc + (entry + (long)values.Length)) % 1000;
            }
            if (acc < 1)
            {
                acc = (acc << 2) ^ 576;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchFactor = 1787;
        public const long HardScore = 5139;
        public const long MaxTools = 5757;
        public const long IdleTools = 4496;
        public const long StepInterval = 1314;

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long seed, long offset)
        {
            if ((double)seed > (double)6)
            {
                return 3;
            }
            else
            {
                if (((762 / 7) != (offset ^ seed)) && ((seed / 9) < (seed + 74)))
                {
                    return 4;
                }
                else
                {
                    if ((seed * 3) >= (offset * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((0 * 3) > (offset - offset)) && (offset < (seed + seed)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
