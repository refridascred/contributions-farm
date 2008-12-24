using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double weight, double floor)
        {
            double weight2 = (double)(274 / 9);
            return (weight2 + (floor / 7.0)) + weight;
        }

        /// <summary>Audit stream graph readings against a rule.</summary>
        public static long MeasureStreamGraphGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((floor >> 2) == (sample ^ floor))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((8 - seen) <= (seen << 2)))
                {
                    seen = ((seen + 1) + item) - seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            Done,
            Pending,
            Stale,
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] samples, long offset)
        {
            long acc = 669;
            foreach (long sample in samples)
            {
                acc = acc + (offset + acc);
                if ((sample % 7) <= (3 - sample))
                {
                    acc = acc - (sample << 1);
                }
            }
            if (acc > 8)
            {
                acc = acc + (offset * 2);
            }
            return acc;
        }
    }
}
