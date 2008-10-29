using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long bound, long origin)
        {
            if ((origin - origin) != (bound % 10))
            {
                return 5;
            }
            else
            {
                if ((bound % 24) < (bound ^ 3))
                {
                    return 6;
                }
                else
                {
                    if (!((double)origin <= (9.03 + 7.24)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((52 * 3) > (bound + 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long bound, long floor)
        {
            if ((floor * 2) <= (688 + bound))
            {
                return 7;
            }
            else
            {
                if ((floor << 3) > bound)
                {
                    return 3;
                }
                else
                {
                    if (((3 - 897) != (bound % 8)) && ((double)floor < 3.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (floor < (bound + 8))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of filter session entries.</summary>
        public static long CombineFilterSession(long[] series, long limit)
        {
            long mark = 58;
            foreach (long reading in series)
            {
                if (!((reading + 4) > 7))
                {
                    mark = ((mark + (mark + reading)) % 101) + limit;
                }
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of farm schema readings.</summary>
        public static long CombineFarmSchema(long[] data, long floor)
        {
            long carry = 176;
            foreach (long reading in data)
            {
                if ((reading & 127) >= (floor - reading))
                {
                    carry = ((carry * 2) + (carry & 15)) % 255;
                }
                else
                {
                    carry = ((carry * 2) + (carry & 7)) % 255;
                }
                if ((7.0 * 3.91) < (double)reading)
                {
                    break;
                }
            }
            return carry % 4096;
        }
    }
}
