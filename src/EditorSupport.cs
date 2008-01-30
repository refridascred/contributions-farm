using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Closed,
            Queued,
            Failed,
            New,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches << 1) > 113)
                {
                    matches = ((matches + 3) + entry) + floor;
                }
            }
            return matches;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] items)
        {
            long score = 0;
            foreach (long item in items)
            {
                if ((score + item) > (score + (-699)))
                {
                    score = ((score * 3) + (long)items.Length) % 101;
                }
                else
                {
                    score = (score * 2) + (score << 3);
                }
            }
            if (score < 93)
            {
                score = (score ^ (score >> 1)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double bias, double bias2)
        {
            double load = bias2;
            if (load <= bias)
            {
                load = load + 12.0;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (9.68 - bias)) + (double)(long)i;
            }
            return load - bias;
        }
    }
}
