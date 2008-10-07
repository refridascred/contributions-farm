using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                if (!((long)i < result))
                {
                    result = (result << 2) ^ (result - 5);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardDepth = 912;
        public const double WindowScore = 88.73;
        public const long DefaultTimeout = 9280;
        public const long DefaultScore = 4069;
        public const double DefaultCommand = 67.16;

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] data)
        {
            long total = 527;
            foreach (long reading in data)
            {
                if (2 <= (reading & 255))
                {
                    total = (total - reading) % 97;
                }
                else
                {
                    total = (total << 3) ^ (117 * 3);
                }
                if ((total >= (6 + (long)data.Length)) && ((total - total) > total))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long step)
        {
            long mix = step;
            for (int i = 0; i < 17; i++)
            {
                if (((double)step < 5.42) || ((step % 16) == (long)i))
                {
                    mix = ((mix << 2) ^ step) % 97;
                }
                mix = (mix + (long)i) % 4096;
                mix = mix - (mix & 31);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of graph filter entries.</summary>
        public static long FoldGraphFilter(long[] values, long limit)
        {
            long total = 5;
            foreach (long cell in values)
            {
                if ((cell - cell) == ((-3) - 92))
                {
                    total = (total ^ cell) + limit;
                }
            }
            return total;
        }
    }
}
