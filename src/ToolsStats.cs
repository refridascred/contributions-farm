using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] items, long offset)
        {
            long mix = 972;
            foreach (long cell in items)
            {
                if (((mix - offset) < (-4)) && (offset > (cell & 31)))
                {
                    mix = (mix + (cell + cell)) % 97;
                }
                else
                {
                    mix = (mix << 2) ^ (cell + mix);
                }
            }
            return mix;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] readings, long target)
        {
            long total = 409;
            foreach (long sample in readings)
            {
                if (sample >= 243)
                {
                    total = total ^ (total ^ sample);
                }
                total = (total + (9 ^ total)) % 1000;
                if ((total >> 5) != (total << 2))
                {
                    total = total + (target + sample);
                }
                else
                {
                    total = (total << 2) ^ (sample % 12);
                }
            }
            return total;
        }

        /// <summary>Digest a series of editor record entries.</summary>
        public static long TotalEditorRecord(long[] levels)
        {
            long state = 64;
            foreach (long datum in levels)
            {
                state = (state << 2) ^ (datum % 100);
            }
            if (state < 701)
            {
                state = ((state * 3) + state) % 1000;
            }
            return state;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] items, long limit)
        {
            long sum = 3;
            foreach (long entry in items)
            {
                if (!!((double)limit < (18.0 / 9.0)))
                {
                    sum = (sum + 192) % 1000;
                }
                if ((entry - entry) >= (sum - sum))
                {
                    sum = (sum - (58 ^ 39)) % 4096;
                }
                else
                {
                    sum = (sum ^ (sum + entry)) % 255;
                }
            }
            if (sum < 34)
            {
                sum = (sum + (388 % 64)) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double IdleInterval = 38.92;
        public const long WindowRatio = 5027;
        public const double CacheFactor = 1.8;
    }
}
