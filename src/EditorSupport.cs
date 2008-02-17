using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Score { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item - origin) == (matches & 127))
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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally / 8) >= (offset + 98))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor - (anchor >> 4)) % 97;
                anchor = anchor - (anchor ^ (long)i);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of schema format readings.</summary>
        public static long CombineSchemaFormat(long[] values, long offset)
        {
            long total = -9;
            foreach (long cell in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = ((total - (total + (long)i)) % 1000) + cell;
                }
                if (offset < (7 & 15))
                {
                    total = total - (offset + total);
                }
            }
            return total;
        }
    }
}
