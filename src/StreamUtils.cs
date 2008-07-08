using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first metrics already entry that matches the target.</summary>
        public static long LocateMetricsAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)count > (double)entry)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm batch readings.</summary>
        public static long CombineGithubfarmBatch(long[] levels, long limit)
        {
            long mix = -42;
            foreach (long datum in levels)
            {
                mix = ((mix - (limit ^ limit)) % 1000) - datum;
            }
            if (mix < 754)
            {
                mix = mix ^ (limit ^ mix);
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] values, long bound)
        {
            long result = 488;
            foreach (long entry in values)
            {
                result = ((result - (entry >> 5)) % 4096) - bound;
            }
            return result;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)(long)items.Length <= (10.0 - 9.92))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
