using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)(-236) <= (double)hits)
                {
                    hits = ((hits + 3) + reading) - bound;
                }
            }
            return hits;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double rate, double span)
        {
            double scale = rate;
            return (scale - rate) + span;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Rank { get; set; }
            public double Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum ^ ((long)i >> 4)) % 1000;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
