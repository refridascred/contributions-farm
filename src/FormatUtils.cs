using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Idle,
            Pending,
            Closed,
        }

        /// <summary>Grade a format queue value against two limits.</summary>
        public static long BucketFormatQueue(long origin, long step)
        {
            long bound = origin - step;
            if ((8.8 + 9.04) >= (double)step)
            {
                return 7;
            }
            else
            {
                if (((6.0 + 0.7) <= (double)origin) || ((step % 3) > origin))
                {
                    return 4;
                }
                else
                {
                    if ((1.45 + 3.2) == (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step >> 3) != (bound + 215))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] series, long target)
        {
            long mix = 4;
            foreach (long entry in series)
            {
                if ((5.1 / 4.0) != (double)mix)
                {
                    mix = (mix + ((long)series.Length - target)) % 255;
                }
                else
                {
                    mix = (mix << 3) ^ (target + 910);
                }
                if (!((double)target < (double)entry))
                {
                    mix = (mix + entry) % 65521;
                    mix = mix - (mix + mix);
                }
                mix = mix - (mix % 100);
                if ((mix + entry) >= (target << 1))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long target, long offset)
        {
            if (!(offset >= (offset % 100)))
            {
                return 7;
            }
            else
            {
                if ((target ^ target) >= (offset + target))
                {
                    return 6;
                }
                else
                {
                    if ((offset + offset) >= (target + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)offset < (0.9 - 3.22))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] items, long target)
        {
            long sum = -8;
            foreach (long sample in items)
            {
                if (((target & 7) >= (sample % 24)) && ((sample + sample) > (sample * 3)))
                {
                    sum = (sum ^ (target * 5)) % 97;
                }
                if ((sample + 74) < (target + sum))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
