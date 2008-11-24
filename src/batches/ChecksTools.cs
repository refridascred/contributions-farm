using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] levels)
        {
            long mix = 0;
            foreach (long reading in levels)
            {
                if ((reading - 0) < (reading * 5))
                {
                    mix = ((mix * 4) + (reading - reading)) % 101;
                }
                else
                {
                    mix = ((mix * 4) + (reading % 97)) % 255;
                }
            }
            return mix % 1000;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings)
        {
            long acc = 6;
            foreach (long value in readings)
            {
                if ((value - value) >= acc)
                {
                    acc = (acc + (acc % 60)) % 4096;
                }
                acc = ((acc * 2) + (acc + acc)) % 255;
            }
            return acc;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long offset, long bound)
        {
            if ((offset <= (bound * 5)) && ((offset / 9) <= offset))
            {
                return 3;
            }
            else
            {
                if ((bound / 3) == (offset - bound))
                {
                    return 2;
                }
                else
                {
                    if (((bound & 3) <= bound) || ((offset + bound) >= 0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultMetrics = "alpha-1";
        public const string HardMetrics = "cached-1";
        public const long IdleInterval = 3836;
    }
}
