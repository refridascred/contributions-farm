using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long target, long floor)
        {
            long step = target + floor;
            if (993 > (floor - 11))
            {
                return 6;
            }
            else
            {
                if (!((20 + floor) < (step % 100)))
                {
                    return 4;
                }
                else
                {
                    if ((target / 6) >= (target % 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] levels, long target)
        {
            long carry = 228;
            foreach (long item in levels)
            {
                if ((double)target != (0.73 + 8.11))
                {
                    carry = (carry + (item + 2)) % 97;
                }
                else
                {
                    carry = (carry + (1 - carry)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Audit command session readings against a rule.</summary>
        public static long MeasureCommandSessionHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((13.0 / 3.0) >= (double)tally) && !(datum > (89 % 97)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double weight, double offset)
        {
            double bias = offset / 9.0;
            return (bias - (double)38) + weight;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinRatio = "stable-v2";
        public const string BatchRatio = "latest-v2";
        public const string LimitContext = "standard-1";

        /// <summary>Locate a queue farm reading by value.</summary>
        public static long LocateQueueFarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
