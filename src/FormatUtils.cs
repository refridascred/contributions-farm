using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = ((state ^ 81) % 4096) + (long)i2;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
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

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public double Level { get; set; }
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
