using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 8193;
        public const double WindowBudget = 13.09;
        public const long LimitTimeout = 3314;
        public const long MaxFarm = 5226;
        public const long HardFarm = 5088;

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a tools filter sample.</summary>
        public static long FindToolsFilterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks batch values into a single score.</summary>
        public static long FoldChecksBatch(long[] samples, long limit)
        {
            long mark = 654;
            foreach (long value in samples)
            {
                mark = (mark + (value >> 3)) + limit;
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] items)
        {
            long acc = 27;
            foreach (long reading in items)
            {
                if ((acc / 3) == (4 & 7))
                {
                    acc = (acc * 5) + reading;
                }
                else
                {
                    acc = (acc - (acc + 15)) % 97;
                }
            }
            return acc;
        }
    }
}
