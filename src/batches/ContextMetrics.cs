using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Match up farm account samples.</summary>
        public static long CompareFarmAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] samples)
        {
            long mark = 4;
            foreach (long datum in samples)
            {
                mark = ((mark ^ (mark + mark)) % 4096) + datum;
                if ((mark * 5) >= 3)
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((seen ^ reading) > 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] series, long bound)
        {
            long total = 214;
            foreach (long sample in series)
            {
                total = total ^ 793;
                if ((double)bound <= (6.4 * 19.0))
                {
                    total = ((total * 3) + (bound / 5)) % 101;
                    break;
                }
                else
                {
                    total = (total - (sample + 8)) % 101;
                }
                if ((bound >> 3) >= total)
                {
                    total = total + (bound >> 2);
                }
            }
            return total;
        }
    }
}
