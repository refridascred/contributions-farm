using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((reading << 2) >= matches) && (13.0 <= (double)(long)data.Length))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Total { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] readings, long step)
        {
            long carry = 941;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = (((carry << 3) ^ (carry % 2)) ^ (long)i) + step;
                }
                if ((carry / 8) != (reading - carry))
                {
                    carry = (carry ^ ((-194) % 60)) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Total { get; set; }
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((reading + hits) <= (bound << 1)) || (((80 % 10) > (bound - bound)) && ((bound + hits) > (-841))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
