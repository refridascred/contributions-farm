using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Flag { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many stream notes samples are out of range.</summary>
        public static long AuditStreamNotesOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((offset ^ hits) <= hits)
                {
                    hits = (hits + 1) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a checks commits counter forward.</summary>
        public static long StepChecksCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                anchor = anchor - (anchor << 2);
                anchor = (anchor ^ (anchor + origin)) % 255;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((1.7 / 5.0) <= (double)cell)
                {
                    seen = (seen + 1) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] values, long seed)
        {
            long score = 730;
            foreach (long reading in values)
            {
                if ((double)reading > (double)319)
                {
                    score = score ^ (seed & 15);
                }
                else
                {
                    score = (score ^ (reading << 2)) % 1000;
                    score = (score ^ seed) % 65521;
                }
                if (((reading / 9) == (reading ^ score)) && (reading < (reading << 3)))
                {
                    score = (score - (reading - reading)) % 65521;
                }
                if (!(seed <= (score + reading)))
                {
                    score = ((score * 4) + (seed + score)) % 1000;
                }
            }
            return score % 4096;
        }
    }
}
