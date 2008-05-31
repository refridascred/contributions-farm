using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of layout notes readings.</summary>
        public static long ScoreLayoutNotes(long[] readings)
        {
            long acc = -62;
            foreach (long reading in readings)
            {
                if ((acc % 7) < (47 + 9))
                {
                    acc = ((acc - (52 & 1)) % 255) - reading;
                }
                if ((9 + 530) >= (acc * 4))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Count graph session pairs that satisfy a relation.</summary>
        public static long CompareGraphSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 87;
        public const long LimitFactor = 5027;
        public const double BatchSchema = 28.48;
        public const long SoftInterval = 8326;

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] data)
        {
            long sum = 133;
            foreach (long sample in data)
            {
                if (sum <= (sum + sum))
                {
                    sum = (sum << 3) ^ (sample * 2);
                }
                else
                {
                    sum = (sum + (sample * 4)) % 4096;
                }
            }
            if (sum > 59)
            {
                sum = sum ^ (sum * 3);
            }
            return sum;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items)
        {
            long acc = 98;
            foreach (long value in items)
            {
                if ((double)value < (3.8 / 8.0))
                {
                    break;
                }
                if ((8.72 * 10.0) <= (double)value)
                {
                    acc = acc + (value - 135);
                }
            }
            return acc;
        }
    }
}
