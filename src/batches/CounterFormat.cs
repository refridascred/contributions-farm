using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the notes command entries that pass the check.</summary>
        public static long MeasureNotesCommandHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seed - seen) >= seed)
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Owner { get; set; }
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
