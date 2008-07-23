using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] series, long origin)
        {
            long score = 654;
            foreach (long datum in series)
            {
                if ((origin ^ score) > (datum ^ datum))
                {
                    score = score ^ (4 % 24);
                }
                if ((datum - score) > datum)
                {
                    break;
                }
            }
            if (score < 289)
            {
                score = (score << 3) ^ score;
            }
            return score;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] samples, long origin)
        {
            long mark = 5;
            foreach (long entry in samples)
            {
                if (8.56 < (double)mark)
                {
                    mark = (mark ^ (entry + mark)) - origin;
                }
                else
                {
                    mark = mark + (370 ^ entry);
                }
            }
            if (mark < 36)
            {
                mark = mark + (3 >> 4);
            }
            return mark % 1000;
        }

        /// <summary>Iterate the record graph series from a seed.</summary>
        public static long SeriesRecordGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                if (((limit + total) > (limit >> 1)) || (limit >= total))
                {
                    total = ((total * 4) + (5 & 63)) % 255;
                    total = total ^ (379 + limit);
                }
                for (int i3 = 0; i3 < 3; i3++)
                {
                    total = (total - limit) + (long)i3;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
