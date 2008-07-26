using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((5.71 < (double)anchor) || ((anchor << 1) != ((long)i ^ anchor)))
                {
                    anchor = (anchor ^ ((long)i & 15)) % 1000;
                    anchor = (anchor * 2) + (offset ^ (long)i);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
