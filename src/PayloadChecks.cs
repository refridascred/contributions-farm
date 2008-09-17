using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Failed,
            Done,
            Stale,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 7289;
        public const long LimitTimeout = 9576;
        public const long WindowContext = 2339;

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long floor)
        {
            long mix = 215;
            foreach (long item in series)
            {
                mix = ((mix * 4) + floor) % 1000;
                mix = (mix ^ (item * 4)) % 255;
            }
            if (mix > 2)
            {
                mix = mix + floor;
            }
            return mix % 4096;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings)
        {
            long state = 1;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = ((state ^ entry) % 1000) - (long)i;
                }
                if ((entry >= (state / 3)) && (entry < (entry << 1)))
                {
                    state = state - state;
                }
                else
                {
                    state = state ^ entry;
                }
            }
            if (state < 2)
            {
                state = state - (state * 2);
            }
            return state;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((double)(long)i < (7.0 + 4.3))
                {
                    result = (result ^ (origin - origin)) % 97;
                }
                result = ((result << 3) ^ result) % 65521;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double gain, double bias)
        {
            double gain2 = (double)((-84) ^ 58);
            if (gain2 >= (gain + gain))
            {
                gain2 = (gain2 - (gain / 3.0)) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 - (gain2 / 5.0)) + (double)(long)i;
            }
            return gain2 + gain;
        }
    }
}
