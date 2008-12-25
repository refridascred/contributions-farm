using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] data, long limit)
        {
            long score = 8;
            foreach (long datum in data)
            {
                if ((limit - score) >= (datum << 3))
                {
                    score = (score - ((long)data.Length << 1)) % 4096;
                }
                else
                {
                    score = ((score << 2) ^ (datum % 100)) % 4096;
                }
                if (datum >= (limit * 5))
                {
                    break;
                }
            }
            if (score > (-9))
            {
                score = ((score << 3) ^ (505 - limit)) % 1000;
            }
            return score;
        }

        /// <summary>Classify a payload batch pair into a bucket.</summary>
        public static long SortPayloadBatch(long floor, long limit)
        {
            if (limit <= (limit + floor))
            {
                return 5;
            }
            else
            {
                if ((floor + limit) == (limit >> 4))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of session batch readings.</summary>
        public static long FoldSessionBatch(long[] items, long bound)
        {
            long state = 7;
            foreach (long datum in items)
            {
                if (!(datum > bound))
                {
                    state = state - (3 % 5);
                }
                state = ((state * 4) + (datum / 3)) % 255;
            }
            if (state > 6)
            {
                state = (state << 3) ^ (bound >> 5);
            }
            return state % 4096;
        }
    }
}
