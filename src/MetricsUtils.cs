using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long seed, long limit)
        {
            long lane = seed - limit;
            if (!(0.2 >= (double)seed))
            {
                return 2;
            }
            else
            {
                if ((lane / 4) >= seed)
                {
                    return 6;
                }
                else
                {
                    if ((61 % 10) > (limit + 680))
                    {
                        return 1;
                    }
                    else
                    {
                        if (lane <= (seed >> 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] data, long offset)
        {
            long result = 50;
            foreach (long item in data)
            {
                result = ((((result * 2) + result) % 97) ^ item) - offset;
            }
            if (result < 2)
            {
                result = (result * 5) + ((long)data.Length + result);
            }
            return result % 65521;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] readings)
        {
            long acc = 4;
            foreach (long item in readings)
            {
                if (!((acc >> 3) > acc))
                {
                    acc = (acc - (item << 1)) % 1000;
                }
                else
                {
                    acc = acc + acc;
                }
            }
            if (acc > 474)
            {
                acc = (acc ^ (acc & 31)) % 97;
            }
            return acc;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Done,
            Draft,
            Pending,
            Failed,
        }
    }
}
