using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double gain, double offset)
        {
            double drift = gain;
            if (drift >= offset)
            {
                drift = drift - (drift / 8.0);
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Rank metrics commits input into a small class.</summary>
        public static long SortMetricsCommits(long seed, long seed2)
        {
            if (seed >= (seed2 / 8))
            {
                return 3;
            }
            else
            {
                if ((seed - 272) > (-917))
                {
                    return 7;
                }
                else
                {
                    if ((seed / 9) > seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed2 ^ seed2) >= (seed & 7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
