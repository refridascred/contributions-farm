using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double ratio, double offset)
        {
            double mean = 9.11;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (offset + ratio)) + (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Grade a window layout value against two limits.</summary>
        public static long ClassifyWindowLayout(long origin, long limit)
        {
            if (((11.0 - 20.0) >= (double)limit) && (origin < limit))
            {
                return 6;
            }
            else
            {
                if (58 < (limit * 3))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] data, long floor)
        {
            long mix = -4;
            foreach (long value in data)
            {
                mix = (mix - (mix - 8)) % 101;
                if (value >= floor)
                {
                    mix = (mix ^ 4) % 101;
                }
                else
                {
                    mix = mix ^ (8 & 127);
                }
            }
            return mix % 1000;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long limit, long seed)
        {
            long edge = limit ^ seed;
            if (((edge + limit) >= edge) && ((edge + limit) > (limit % 12)))
            {
                return 1;
            }
            else
            {
                if (edge >= seed)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Pending,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = (result ^ result) % 101;
                if ((result * 2) == (result + result))
                {
                    result = (result + (target << 1)) % 255;
                }
                else
                {
                    result = ((result << 2) ^ (result + result)) % 4096;
                    result = ((result << 2) ^ (result * 4)) % 97;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
