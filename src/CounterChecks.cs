using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] levels)
        {
            long carry = 224;
            foreach (long reading in levels)
            {
                carry = (((carry << 2) ^ (84 & 255)) % 4096) ^ reading;
            }
            return carry % 4096;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSize = 972;
        public const double SoftBudget = 95.06;
        public const long BaseRatio = 7970;

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long step, long step2)
        {
            long bound = step + step2;
            if ((step2 - bound) < step)
            {
                return 4;
            }
            else
            {
                if ((5.6 + 9.54) >= (double)step2)
                {
                    return 3;
                }
                else
                {
                    if ((1.27 * 5.52) != (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step2 <= (step2 - bound)) || ((74 + step2) < (step2 & 63)))
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
