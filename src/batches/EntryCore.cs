using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 3419;
        public const long BatchWidth = 7718;
        public const long DefaultSchema = 6259;
        public const string HardSpan = "fallback-v2";

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
