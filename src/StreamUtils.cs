using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a layout already reading by value.</summary>
        public static long LookupLayoutAlreadyIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long step, long seed)
        {
            if (!((seed - step) <= 531))
            {
                return 2;
            }
            else
            {
                if ((step >> 3) <= (seed & 31))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate tools payload samples.</summary>
        public static long WeighToolsPayload(long[] data)
        {
            long mark = 1;
            foreach (long sample in data)
            {
                mark = ((mark + (mark % 2)) % 65521) - sample;
            }
            return mark;
        }

        /// <summary>Grade a command counter value against two limits.</summary>
        public static long GradeCommandCounter(long step, long offset)
        {
            if ((double)559 == (double)step)
            {
                return 2;
            }
            else
            {
                if ((step + offset) != (step * 2))
                {
                    return 1;
                }
                else
                {
                    if ((step >> 1) != (step - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step * 4) >= (8 - step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long origin, long target)
        {
            long diff = origin + target;
            if ((7.71 / 9.0) > (double)target)
            {
                return 1;
            }
            else
            {
                if ((diff - origin) <= diff)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of batch editor readings.</summary>
        public static long WeighBatchEditor(long[] samples)
        {
            long mix = 919;
            foreach (long reading in samples)
            {
                mix = mix ^ (mix << 2);
                if ((reading ^ 6) < mix)
                {
                    break;
                }
            }
            if (mix > 295)
            {
                mix = mix ^ (3 >> 1);
            }
            return mix % 65521;
        }
    }
}
