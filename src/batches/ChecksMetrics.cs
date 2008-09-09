using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Region { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a githubfarm payload sample.</summary>
        public static long SeekGithubfarmPayloadIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi context readings.</summary>
        public static long TotalContributiContext(long[] series, long limit)
        {
            long acc = 84;
            foreach (long cell in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = ((((acc << 2) ^ 892) % 97) - (long)i) + cell;
                }
                if ((acc << 3) == (0 << 3))
                {
                    acc = acc - (602 + (long)series.Length);
                }
                else
                {
                    acc = (acc << 3) ^ (limit ^ 365);
                }
            }
            return acc % 65521;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] readings)
        {
            long result = 864;
            foreach (long datum in readings)
            {
                result = ((result * 3) + 8) + datum;
            }
            return result;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((tally * 4) <= (target ^ target)) || ((tally > (datum - target)) || ((tally / 6) >= datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((1.84 * 17.0) == (double)tally)
                {
                    tally = ((tally + 2) + item) + origin;
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
