using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a batches editor value against two limits.</summary>
        public static long BucketBatchesEditor(long offset, long bound)
        {
            long gap = offset + bound;
            if ((bound <= (22 + 983)) || ((8.36 / 4.0) != (double)offset))
            {
                return 8;
            }
            else
            {
                if (!((bound * 4) > (87 >> 2)))
                {
                    return 6;
                }
                else
                {
                    if ((gap & 1) == (bound & 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset ^ 79) > (bound * 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((52 ^ reading) != (seen & 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 6384;
        public const long DefaultOrder = 5327;
        public const long IdleOrder = 274;
        public const long BatchLevel = 6479;
        public const string BatchOrder = "strict-v2";
    }
}
