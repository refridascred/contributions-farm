using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] items)
        {
            long anchor = 195;
            foreach (long cell in items)
            {
                anchor = ((anchor * 3) + cell) % 1000;
                anchor = (anchor - (cell / 7)) % 97;
                if ((double)(-9) <= (double)anchor)
                {
                    anchor = anchor - 45;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)cell >= (1.36 + 1.0))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Roll a metrics githubfarm counter forward.</summary>
        public static long IterateMetricsGithubfarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                mix = mix + offset;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
