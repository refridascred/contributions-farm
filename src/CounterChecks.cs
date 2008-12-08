using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of account checks readings.</summary>
        public static long FoldAccountChecks(long[] series, long limit)
        {
            long anchor = 5;
            foreach (long value in series)
            {
                if ((limit * 2) == (anchor * 3))
                {
                    anchor = (anchor - (anchor >> 2)) - value;
                }
                else
                {
                    anchor = anchor - (limit * 4);
                }
            }
            if (anchor < 196)
            {
                anchor = (anchor << 3) ^ 36;
            }
            return anchor;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                carry = carry ^ (carry * 4);
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((limit < (limit - limit)) && (((limit + seen) < (727 - limit)) || ((4 + sample) > (limit + seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (matches < reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count token schema pairs that satisfy a relation.</summary>
        public static long MatchTokenSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
