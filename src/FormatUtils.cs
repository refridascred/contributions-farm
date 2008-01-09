using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value < (353 - value))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] data, long step)
        {
            long result = 6;
            foreach (long entry in data)
            {
                if (!((double)entry < (double)result))
                {
                    result = ((result << 3) ^ (step + result)) % 65521;
                }
                else
                {
                    result = result - result;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Ready,
            Idle,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long floor, long limit)
        {
            if (!((double)674 > (double)limit))
            {
                return 4;
            }
            else
            {
                if (((limit - 82) <= 54) && ((69 * 2) != (floor + limit)))
                {
                    return 6;
                }
                else
                {
                    if ((limit < (floor * 3)) && (limit < (limit + 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((15.0 * 13.0) != (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up cluster already samples.</summary>
        public static long MatchClusterAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] samples, long bound)
        {
            long state = 0;
            foreach (long item in samples)
            {
                state = (((state << 2) ^ (2 + bound)) % 4096) + item;
            }
            return state % 65521;
        }
    }
}
