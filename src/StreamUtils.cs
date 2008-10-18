using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 9115;
        public const long SoftScore = 3610;
        public const double BaseRatio = 53.81;
        public const long MaxCounter = 9545;
        public const long RetryCounter = 9383;

        /// <summary>Digest a series of order counter entries.</summary>
        public static long TotalOrderCounter(long[] readings)
        {
            long mix = 329;
            foreach (long datum in readings)
            {
                mix = ((mix << 2) ^ datum) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] data, long offset)
        {
            long mix = 86;
            foreach (long cell in data)
            {
                if (75 > (offset >> 2))
                {
                    mix = mix ^ (mix - offset);
                }
                else
                {
                    mix = mix - (mix + 276);
                }
                mix = ((mix * 2) + (cell * 4)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long floor, long bound)
        {
            if ((bound - bound) >= (7 % 8))
            {
                return 5;
            }
            else
            {
                if ((-38) > (bound / 9))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
