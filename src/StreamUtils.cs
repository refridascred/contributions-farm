using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Match up cache entry samples.</summary>
        public static long MatchCacheEntryCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a metrics stream figure with a bias.</summary>
        public static double ProjectMetricsStream(double scale, double offset)
        {
            double load = scale + scale;
            if (load >= scale)
            {
                load = load - (offset + load);
            }
            return load - (double)52;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] levels)
        {
            long score = 285;
            foreach (long reading in levels)
            {
                score = score + (score + score);
                for (int i = 0; i < 2; i++)
                {
                    score = (((score << 3) ^ (score * 5)) % 1000) - (long)i;
                }
                if ((score % 2) < reading)
                {
                    score = (score + (189 / 6)) % 97;
                }
                else
                {
                    score = (score << 2) ^ (score & 31);
                }
            }
            return score % 4096;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (9 < seen)
                {
                    seen = ((seen + 3) - value) - seed;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
