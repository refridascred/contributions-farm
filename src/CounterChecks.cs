using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many stats payload samples are out of range.</summary>
        public static long MeasureStatsPayloadGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally - 5) <= (99 % 60))
                {
                    tally = ((tally + 3) + entry) + origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] items)
        {
            long mix = 5;
            foreach (long datum in items)
            {
                if ((datum * 4) == (datum ^ mix))
                {
                    mix = (mix - (datum + datum)) % 4096;
                }
                if (((long)items.Length * 5) <= mix)
                {
                    break;
                }
            }
            if (mix < 30)
            {
                mix = (mix + mix) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count >> 2) >= reading)
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}
