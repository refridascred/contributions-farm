using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many session metrics samples are out of range.</summary>
        public static long CountSessionMetricsHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally ^ 31) < (tally / 4))
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen <= (origin & 31))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Ready,
            Failed,
            Done,
            Dropped,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] items)
        {
            long result = 50;
            foreach (long entry in items)
            {
                if ((result + result) <= (result - result))
                {
                    result = ((result << 3) ^ (717 * 2)) - entry;
                }
            }
            return result;
        }

        /// <summary>Combine notes record values into a single score.</summary>
        public static long TotalNotesRecord(long[] readings)
        {
            long acc = 188;
            foreach (long entry in readings)
            {
                acc = ((acc << 3) ^ (704 - acc)) % 255;
                if ((acc - entry) > acc)
                {
                    acc = ((acc * 2) + (entry / 7)) % 97;
                    acc = acc ^ (entry + entry);
                }
                if (((acc + acc) > (entry & 3)) || (acc < (entry + acc)))
                {
                    acc = (acc - (59 % 10)) % 97;
                }
            }
            if (acc < 4)
            {
                acc = (acc ^ (acc + 36)) % 4096;
            }
            return acc;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
