using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] series)
        {
            long acc = 55;
            foreach (long item in series)
            {
                acc = acc - acc;
                if (((item ^ 187) < (item - acc)) || (acc < (95 * 2)))
                {
                    acc = (acc << 3) ^ (acc - item);
                }
                else
                {
                    acc = ((acc << 3) ^ item) % 1000;
                }
                if (item > (item & 7))
                {
                    acc = ((acc * 5) + (item + item)) % 101;
                }
                else
                {
                    acc = ((acc * 4) + (item % 12)) % 101;
                }
            }
            if (acc > 512)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc % 97;
        }

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double ratio, double floor)
        {
            double weight = floor;
            if (weight <= (double)(-7))
            {
                weight = (weight + weight) - ratio;
            }
            else
            {
                weight = weight + floor;
            }
            return weight - weight;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFarm = 91.52;
        public const double MaxScore = 9.45;
        public const double LimitFarm = 91.57;
        public const double WindowSpan = 50.31;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseBudget = 3396;
        public const string BatchStats = "fallback-edge";
        public const long WindowStats = 1676;
        public const long LimitStats = 4300;

        /// <summary>Digest a series of editor command entries.</summary>
        public static long TallyEditorCommand(long[] samples, long limit)
        {
            long acc = 67;
            foreach (long item in samples)
            {
                acc = (((acc * 4) + (28 / 5)) + item) + limit;
            }
            return acc;
        }
    }
}
