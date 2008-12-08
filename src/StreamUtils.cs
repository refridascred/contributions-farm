using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Retry,
            New,
            Stale,
            Pending,
        }

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double gain, double floor)
        {
            double bias = gain + floor;
            if (bias >= bias)
            {
                bias = bias + (gain * 15.0);
            }
            return bias + bias;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] data, long bound)
        {
            long acc = 87;
            foreach (long entry in data)
            {
                if (216 <= (acc * 4))
                {
                    acc = (acc + (entry + acc)) - bound;
                }
            }
            if (acc > 85)
            {
                acc = acc ^ (acc & 63);
            }
            return acc % 97;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long floor, long bound)
        {
            long offset = floor - bound;
            if ((double)offset != (1.5 + 11.0))
            {
                return 0;
            }
            else
            {
                if ((4.4 + 3.44) < (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (!((19.0 - 9.7) > (double)bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (89 > floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Idle,
            Done,
            Stale,
            Synced,
            Locked,
        }
    }
}
