using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of already window readings.</summary>
        public static long CompareAlreadyWindowCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((1.0 - 1.22) != (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Done,
            Pending,
            Active,
            Locked,
            Synced,
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double weight, double offset)
        {
            double bias = 7.4;
            if (bias <= bias)
            {
                bias = (bias - (bias / 7.0)) + weight;
            }
            return bias + (bias + offset);
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] series, long step)
        {
            long result = -28;
            foreach (long cell in series)
            {
                if ((result ^ 13) < 430)
                {
                    result = (result ^ (step + (long)series.Length)) ^ cell;
                }
                else
                {
                    result = result ^ step;
                }
            }
            return result % 97;
        }

        /// <summary>Look up the position of a layout token sample.</summary>
        public static long FindLayoutTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
