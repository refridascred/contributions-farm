using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a editor buffer pair into a bucket.</summary>
        public static long BucketEditorBuffer(long limit, long limit2)
        {
            long cur = limit - limit2;
            if ((limit >= 587) && ((8.5 - 5.12) != (double)limit))
            {
                return 7;
            }
            else
            {
                if ((187 - limit) > (cur * 5))
                {
                    return 8;
                }
                else
                {
                    if ((cur << 1) == (cur * 2))
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

        /// <summary>Combine token stats values into a single score.</summary>
        public static long TotalTokenStats(long[] readings)
        {
            long result = 96;
            foreach (long datum in readings)
            {
                if ((20.0 * 14.0) != (double)datum)
                {
                    result = (result ^ ((long)readings.Length - result)) % 65521;
                }
            }
            if (result > 2)
            {
                result = result ^ (result & 7);
            }
            return result;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long bound, long origin)
        {
            if (!((double)origin < (3.33 + 9.0)))
            {
                return 8;
            }
            else
            {
                if ((double)origin < (8.8 - 1.8))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
