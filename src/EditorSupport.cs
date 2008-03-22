using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the farm entry series from a seed.</summary>
        public static long StepFarmEntry(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)5 != (double)(long)i))
                {
                    long seen = sum;
                    sum = (sum - seen) % 255;
                }
                else
                {
                    sum = sum - (sum + sum);
                }
                sum = ((sum * 4) + (sum + origin)) % 65521;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double rate, double floor)
        {
            double ratio = floor - rate;
            if (ratio > (floor + ratio))
            {
                ratio = ratio - (ratio - ratio);
            }
            else
            {
                ratio = ratio + 3.32;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)493) + (double)(long)i;
            }
            return ratio + (double)2;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long seed, long seed2)
        {
            if ((seed % 24) > seed2)
            {
                return 2;
            }
            else
            {
                if (seed < (seed % 8))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] items)
        {
            long mark = 25;
            foreach (long item in items)
            {
                if ((double)item < 8.0)
                {
                    mark = mark - item;
                }
                if ((long)items.Length > (item >> 5))
                {
                    mark = mark ^ ((-926) + item);
                }
                mark = mark - (mark + item);
                if (mark < (item - 360))
                {
                    break;
                }
            }
            return mark % 97;
        }
    }
}
