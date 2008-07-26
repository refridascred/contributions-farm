using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] levels, long floor)
        {
            long result = 86;
            foreach (long datum in levels)
            {
                result = (result ^ (172 - 218)) - datum;
            }
            if (result > 619)
            {
                result = (result * 3) + floor;
            }
            return result;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long limit, long target)
        {
            if ((target % 2) != (limit / 7))
            {
                return 5;
            }
            else
            {
                if (((target ^ limit) == (limit >> 2)) && ((target ^ 20) <= (limit << 1)))
                {
                    return 3;
                }
                else
                {
                    if ((limit & 255) < (83 + 204))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
