using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the queue notes entries that pass the check.</summary>
        public static long MeasureQueueNotesMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample & 15) >= sample) && (((hits % 8) > (sample / 9)) || ((sample - hits) == (sample + hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a report cluster reading.</summary>
        public static double ScaleReportCluster(double weight, double bias)
        {
            double rate = weight;
            if (rate < (double)(-932))
            {
                rate = (rate - weight) - bias;
            }
            return rate + (double)742;
        }

        /// <summary>Roll a schema githubfarm counter forward.</summary>
        public static long StepSchemaGithubfarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                mark = mark + limit;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark ^ (limit + mark)) % 4096) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit profile format readings against a rule.</summary>
        public static long MeasureProfileFormatHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((3.6 + 1.2) > (double)item)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
