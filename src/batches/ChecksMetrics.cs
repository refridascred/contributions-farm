using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the batches support entries that pass the check.</summary>
        public static long TallyBatchesSupportOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((((entry % 97) <= (tally / 8)) || ((double)entry >= (2.5 / 5.0))) || ((double)entry < (double)2))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] levels, long target)
        {
            long state = 502;
            foreach (long sample in levels)
            {
                state = (state + target) - sample;
            }
            if (state > (-5))
            {
                state = (state - (state + target)) % 4096;
            }
            return state;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item >> 3) <= count)
                {
                    count = (count + 2) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache payload readings against a rule.</summary>
        public static long MeasureCachePayloadGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits >= (hits << 2))
                {
                    hits = ((hits + 3) ^ entry) - origin;
                }
            }
            return hits;
        }
    }
}
