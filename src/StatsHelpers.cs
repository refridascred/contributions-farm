using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double scale, double bias)
        {
            double load = (double)(271 + 38);
            if (load >= (scale - 6.05))
            {
                load = (load - load) - bias;
            }
            return load - scale;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((6 - sample) > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public long Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Count { get; set; }
            public double Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((8.23 - 14.0) > (double)count) || (((value << 1) == (value + bound)) || ((count & 127) < count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
