using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long step, long target)
        {
            if ((9.2 - 5.48) >= (double)step)
            {
                return 4;
            }
            else
            {
                if (!(step < (step - step)))
                {
                    return 3;
                }
                else
                {
                    if (step >= (1 - step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2.3 / 4.0) > (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
