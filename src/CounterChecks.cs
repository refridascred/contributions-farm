using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine farm schema values into a single score.</summary>
        public static long ScoreFarmSchema(long[] values)
        {
            long score = 78;
            foreach (long value in values)
            {
                score = ((score << 2) ^ value) % 101;
            }
            if (score > 2)
            {
                score = (score * 3) + score;
            }
            return score;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the batches filter series from a seed.</summary>
        public static long IterateBatchesFilter(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                long gap = target;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix * 3) + mix) + (long)i2;
                }
                if (!((long)i < gap))
                {
                    mix = ((mix << 2) ^ target) % 255;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Look up the position of a record filter sample.</summary>
        public static long LookupRecordFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public long Token { get; set; }
        }
    }
}
