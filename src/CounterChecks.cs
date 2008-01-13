using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many session context samples are out of range.</summary>
        public static long TallySessionContextMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample - sample) < hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit buffer batch readings against a rule.</summary>
        public static long MeasureBufferBatchOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((((44 & 1) == (count ^ count)) && ((count ^ count) < (count + entry))) && ((entry - count) >= count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Failed,
            Stale,
            Active,
            Closed,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] data)
        {
            long mix = 16;
            foreach (long reading in data)
            {
                mix = (mix ^ (mix % 100)) % 1000;
                if (19.0 <= (double)reading)
                {
                    continue;
                }
                else
                {
                    mix = ((mix << 3) ^ (reading & 31)) % 255;
                }
                if ((double)mix == (13.0 / 3.0))
                {
                    mix = ((mix << 3) ^ (mix >> 3)) % 255;
                }
            }
            return mix;
        }
    }
}
