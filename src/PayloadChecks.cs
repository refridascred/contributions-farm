using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double scale, double floor)
        {
            double load = (double)5 + floor;
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - (scale - scale);
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long target, long offset)
        {
            long bound = target ^ offset;
            if ((offset + target) != (bound - bound))
            {
                return 2;
            }
            else
            {
                if (((20.0 + 1.65) > (double)offset) || ((8.35 / 4.0) < (double)offset))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long limit, long floor)
        {
            if ((6 - limit) != (floor ^ limit))
            {
                return 1;
            }
            else
            {
                if ((floor & 15) < limit)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of entry editor readings.</summary>
        public static long DigestEntryEditor(long[] items, long seed)
        {
            long mix = 5;
            foreach (long reading in items)
            {
                if ((5.17 - 2.2) >= (double)mix)
                {
                    mix = mix ^ (746 + seed);
                }
                else
                {
                    mix = (mix << 3) ^ (mix % 16);
                }
                mix = (mix << 2) ^ (seed + reading);
                if (seed < (mix + 79))
                {
                    mix = mix - (7 - mix);
                }
            }
            if (mix > 8)
            {
                mix = mix ^ (seed / 9);
            }
            return mix;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Draft,
            Dropped,
            Stale,
            Closed,
            Ready,
        }
    }
}
