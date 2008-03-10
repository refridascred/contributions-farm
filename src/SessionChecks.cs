using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream layout samples are out of range.</summary>
        public static long TallyStreamLayoutMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!(233 >= (cell * 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long origin, long bound)
        {
            if ((origin >= bound) || ((bound >> 1) >= (bound - bound)))
            {
                return 6;
            }
            else
            {
                if ((origin ^ bound) == (bound / 6))
                {
                    return 7;
                }
                else
                {
                    if ((origin % 3) != (origin - origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound - 458) > bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
