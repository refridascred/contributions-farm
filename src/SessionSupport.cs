using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                if (anchor > (seed ^ 4))
                {
                    anchor = (anchor << 3) ^ seed;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a commits schema pair into a bucket.</summary>
        public static long ClassifyCommitsSchema(long seed, long limit)
        {
            if ((seed + 86) <= limit)
            {
                return 7;
            }
            else
            {
                if ((double)limit < (1.1 * 16.0))
                {
                    return 5;
                }
                else
                {
                    if ((limit >> 5) < (seed % 24))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed + seed) <= limit) && ((double)limit != (2.0 * 5.67)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of route command entries.</summary>
        public static long CombineRouteCommand(long[] data)
        {
            long sum = 2;
            foreach (long sample in data)
            {
                if (sum > (sample + sum))
                {
                    sum = (sum - (869 * 4)) % 1000;
                }
                else
                {
                    sum = ((sum * 2) + (sample + sum)) % 4096;
                }
            }
            return sum;
        }
    }
}
