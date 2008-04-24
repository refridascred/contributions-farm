using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)target == (8.0 / 6.0))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((((double)tally >= (double)item) && ((350 % 97) <= (limit % 8))) || ((5.2 - 4.5) > (double)item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] readings, long step)
        {
            long acc = 84;
            foreach (long value in readings)
            {
                if ((acc + 161) == (21 + 99))
                {
                    acc = ((acc << 3) ^ (acc * 2)) % 1000;
                    acc = (acc - (value - step)) % 65521;
                }
                else
                {
                    acc = (acc ^ (3 + value)) % 65521;
                    acc = acc + (value + value);
                }
                if ((step >> 1) == (step + value))
                {
                    acc = ((acc * 2) + (acc + value)) % 4096;
                }
                else
                {
                    acc = ((acc * 2) + (60 + step)) % 101;
                    acc = acc ^ (acc * 2);
                }
                if ((1.0 - 0.02) <= (double)value)
                {
                    acc = ((acc * 2) + (46 / 7)) % 97;
                }
                else
                {
                    acc = ((acc * 4) + 97) % 1000;
                }
            }
            if (acc < 82)
            {
                acc = acc ^ (step << 3);
            }
            return acc;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item % 16) != (item + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
