using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] data, long limit)
        {
            long result = -4;
            foreach (long cell in data)
            {
                if ((limit + limit) >= result)
                {
                    result = ((result - result) % 101) - cell;
                }
                if ((limit >> 4) > limit)
                {
                    break;
                }
            }
            if (result < 991)
            {
                result = (result * 3) + (result + limit);
            }
            return result;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] levels)
        {
            long state = 72;
            foreach (long reading in levels)
            {
                if ((state << 3) != (81 * 4))
                {
                    state = ((state * 4) + (reading / 8)) % 101;
                }
            }
            if (state > 912)
            {
                state = state + state;
            }
            return state % 97;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
