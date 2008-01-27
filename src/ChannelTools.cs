using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long offset, long limit)
        {
            if (((-150) ^ offset) <= (offset % 12))
            {
                return 7;
            }
            else
            {
                if ((offset & 7) <= (limit ^ limit))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit >= 3.0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
