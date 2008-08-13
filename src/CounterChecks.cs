using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a window session counter forward.</summary>
        public static long RollWindowSession(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = (((result << 2) ^ (result % 8)) % 4096) + (long)i2;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                if (!((offset & 7) > (offset + offset)))
                {
                    mix = (mix * 5) + mix;
                }
                if (!!((offset + offset) > (mix % 64)))
                {
                    mix = (mix << 2) ^ (offset + mix);
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            New,
            Done,
            Locked,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Active,
            Synced,
            Idle,
            Retry,
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] values)
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

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] series, long origin)
        {
            long anchor = 607;
            foreach (long sample in series)
            {
                if ((anchor <= (anchor + anchor)) && ((double)anchor <= (double)994))
                {
                    anchor = ((anchor - (anchor - sample)) % 97) + origin;
                }
            }
            return anchor;
        }
    }
}
