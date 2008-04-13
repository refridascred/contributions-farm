using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum << 1) < hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] readings, long target)
        {
            long score = 845;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = ((score ^ datum) ^ (long)i) - target;
                }
                score = ((score << 2) ^ score) % 97;
            }
            return score % 1000;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (matches <= value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                if (!(bound >= (carry - carry)))
                {
                    carry = (carry + (carry / 8)) % 65521;
                }
                if (((bound * 2) < (long)i) && ((carry + carry) >= (carry - bound)))
                {
                    carry = (carry + (long)i) % 4096;
                }
                else
                {
                    carry = (carry << 3) ^ ((long)i & 1);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
