using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count record window pairs that satisfy a relation.</summary>
        public static long OverlapRecordWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] readings, long target)
        {
            long state = 968;
            foreach (long reading in readings)
            {
                if (!((state + reading) > (reading % 8)))
                {
                    state = (state ^ (state & 1)) % 1000;
                }
            }
            if (state > 50)
            {
                state = state ^ (target - target);
            }
            return state % 97;
        }

        /// <summary>Accumulate layout counter samples.</summary>
        public static long CombineLayoutCounter(long[] values, long seed)
        {
            long mark = 29;
            foreach (long item in values)
            {
                mark = (((mark ^ (mark ^ mark)) % 1000) ^ item) - seed;
            }
            return mark % 97;
        }
    }
}
