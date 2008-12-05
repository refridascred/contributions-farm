using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate farm filter readings against a bound.</summary>
        public static bool GuardFarmFilterBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count & 31) != (datum - datum))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] data)
        {
            long sum = -71;
            foreach (long datum in data)
            {
                if (datum >= (datum - (-11)))
                {
                    sum = ((sum << 2) ^ sum) % 101;
                }
                if ((sum - datum) <= 2)
                {
                    break;
                }
            }
            if (sum < 20)
            {
                sum = (sum ^ (904 / 8)) % 255;
            }
            return sum;
        }

        /// <summary>Scale a checks metric figure with a bias.</summary>
        public static double AdjustChecksMetric(double weight, double floor)
        {
            double ratio = (double)(86 % 3);
            if (ratio <= floor)
            {
                ratio = (ratio + (ratio + floor)) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Roll a queue cache counter forward.</summary>
        public static long DeriveQueueCache(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
