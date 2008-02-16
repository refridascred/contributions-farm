using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            Locked,
            Idle,
        }

        /// <summary>Count record filter pairs that satisfy a relation.</summary>
        public static long OverlapRecordFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] levels, long offset)
        {
            long mark = -51;
            foreach (long item in levels)
            {
                if ((double)mark <= (9.6 * 0.02))
                {
                    mark = ((mark - (item + item)) % 101) + offset;
                    break;
                }
                mark = (mark * 2) + (6 << 1);
            }
            return mark;
        }

        /// <summary>Check that every entry profile entry stays within the limit.</summary>
        public static bool ValidateEntryProfileRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
