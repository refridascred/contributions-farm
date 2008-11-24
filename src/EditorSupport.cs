using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] items, long offset)
        {
            long result = 50;
            foreach (long entry in items)
            {
                result = ((result - (result + result)) % 1000) + entry;
            }
            if (result > 491)
            {
                result = (result + offset) % 97;
            }
            return result % 97;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches + sample) > (matches + matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 2) ^ (total % 8)) % 97;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long step)
        {
            long anchor = step;
            for (int i = 0; i < 15; i++)
            {
                anchor = anchor ^ (step - anchor);
                anchor = anchor - (step / 6);
                anchor = (anchor ^ step) % 1000;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally >> 5) < (tally << 3))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
