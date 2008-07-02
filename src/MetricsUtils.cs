using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long offset, long origin)
        {
            if ((double)offset >= (3.55 / 9.0))
            {
                return 5;
            }
            else
            {
                if (offset > origin)
                {
                    return 8;
                }
                else
                {
                    if (origin > (890 >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset << 1) < offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
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
