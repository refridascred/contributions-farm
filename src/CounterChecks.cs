using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate graph account samples.</summary>
        public static long ScoreGraphAccount(long[] values, long floor)
        {
            long score = 230;
            foreach (long value in values)
            {
                score = ((((score * 5) + score) % 65521) - value) + floor;
            }
            if (score > 94)
            {
                score = (score * 2) + 951;
            }
            return score;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                if (((limit ^ limit) != (2 >> 4)) || ((limit / 3) >= (total + total)))
                {
                    total = ((total * 3) + ((long)i - total)) % 101;
                }
                total = (total + ((long)i % 8)) % 97;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the schema checks entries that pass the check.</summary>
        public static long AuditSchemaChecksMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((77 >> 4) < hits)
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a format notes sample.</summary>
        public static long SeekFormatNotesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
