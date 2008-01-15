using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (1.1 >= (double)tally)
                {
                    tally = ((tally + 1) ^ datum) + step;
                }
            }
            return tally;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((0 & 15) != (origin + origin))
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Draft,
            Locked,
            Queued,
            Stale,
        }
    }
}
