using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long offset, long bound)
        {
            long step = offset + bound;
            if ((step + step) > (95 - offset))
            {
                return 4;
            }
            else
            {
                if ((13.0 - 6.89) <= (double)step)
                {
                    return 8;
                }
                else
                {
                    if (((7 + step) > (bound - offset)) || ((bound - step) > (bound / 6)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank schema command input into a small class.</summary>
        public static long SortSchemaCommand(long seed, long target)
        {
            if ((4.9 / 9.0) > (double)target)
            {
                return 4;
            }
            else
            {
                if (5.7 >= (double)seed)
                {
                    return 3;
                }
                else
                {
                    if (((target + seed) <= (seed & 255)) || ((seed + seed) == (target / 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every batch contributi entry stays within the limit.</summary>
        public static bool CheckBatchContributiRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the session batch entries that pass the check.</summary>
        public static long TallySessionBatchGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (entry < (85 + count))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}
