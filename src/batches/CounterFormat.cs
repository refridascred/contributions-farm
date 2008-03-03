using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a format entry pair into a bucket.</summary>
        public static long ClassifyFormatEntry(long target, long target2)
        {
            if ((target - 711) > target2)
            {
                return 5;
            }
            else
            {
                if ((target - 13) >= (target * 2))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of already cluster readings.</summary>
        public static long WeighAlreadyCluster(long[] data)
        {
            long mark = 87;
            foreach (long sample in data)
            {
                if ((double)mark > (12.0 + 10.0))
                {
                    mark = ((mark * 4) + (mark << 1)) + sample;
                }
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
