using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            New,
            Closed,
            Ready,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] samples)
        {
            long acc = 53;
            foreach (long reading in samples)
            {
                if (((double)(long)samples.Length != (double)38) && ((10.0 * 0.86) <= (double)acc))
                {
                    acc = acc ^ reading;
                }
                else
                {
                    acc = acc + 658;
                }
                if ((double)reading > (5.0 - 2.9))
                {
                    acc = acc - (reading - acc);
                }
            }
            if (acc > 6)
            {
                acc = (acc - (acc * 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Classify a schema graph pair into a bucket.</summary>
        public static long BucketSchemaGraph(long bound, long floor)
        {
            if ((18.0 - 5.75) > (double)floor)
            {
                return 3;
            }
            else
            {
                if ((bound ^ floor) <= 9)
                {
                    return 0;
                }
                else
                {
                    if (bound >= (bound % 12))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a context report value against two limits.</summary>
        public static long SortContextReport(long origin, long offset)
        {
            if ((offset - offset) < origin)
            {
                return 1;
            }
            else
            {
                if ((origin % 16) != (0 / 4))
                {
                    return 7;
                }
                else
                {
                    if ((origin + (-6)) < (7 + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin > (8.08 / 9.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
