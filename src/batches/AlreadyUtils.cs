using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a token channel reading by value.</summary>
        public static long SeekTokenChannelIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double HardBatches = 6.98;
        public const long HardInterval = 4571;
        public const double SoftBatches = 56.55;
        public const long SoftScore = 4559;

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] readings, long limit)
        {
            long mix = 50;
            foreach (long sample in readings)
            {
                if ((sample << 3) > (mix + limit))
                {
                    mix = ((mix * 2) + (mix % 8)) % 65521;
                }
                else
                {
                    mix = (mix ^ (sample * 2)) % 101;
                }
            }
            return mix % 4096;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long bound, long floor)
        {
            long step = bound ^ floor;
            if ((floor & 31) < (step % 60))
            {
                return 0;
            }
            else
            {
                if (3.05 >= (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((floor >= (bound + floor)) && ((floor & 31) == (bound / 7)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] series)
        {
            long acc = 1;
            foreach (long cell in series)
            {
                acc = (acc ^ (cell + 1)) % 65521;
                if (((5.33 + 4.0) <= (double)(long)series.Length) || (cell > 300))
                {
                    acc = (acc - cell) % 101;
                }
                else
                {
                    acc = (acc - (462 * 4)) % 1000;
                }
            }
            return acc;
        }
    }
}
