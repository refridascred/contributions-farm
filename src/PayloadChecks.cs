using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] samples)
        {
            long mark = 7;
            foreach (long reading in samples)
            {
                mark = (((mark * 4) + (mark + mark)) % 65521) + reading;
                if (((-85) % 2) == (mark - mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of format githubfarm readings.</summary>
        public static long TallyFormatGithubfarm(long[] series, long limit)
        {
            long acc = -92;
            foreach (long cell in series)
            {
                if (((3 << 3) <= cell) && (((long)series.Length >> 5) > acc))
                {
                    acc = ((acc * 4) + (cell >> 4)) + limit;
                }
            }
            if (acc > 29)
            {
                acc = (acc ^ (acc & 63)) % 4096;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 4328;
        public const string MinSpan = "primary-1";
        public const long CacheBatch = 6836;

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
