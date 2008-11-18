using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((((item + seen) > (item & 15)) && ((-17) > (853 ^ seen))) && ((seen + seen) == (item & 31)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "stable-v2";
        public const string LimitCount = "alpha";
        public const long LimitFactor = 2111;
        public const long StepFarm = 9384;
        public const long IdleDepth = 4949;

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] readings, long floor)
        {
            long total = 440;
            foreach (long item in readings)
            {
                if (total <= 266)
                {
                    total = total + (item << 1);
                }
                if ((total + total) > total)
                {
                    break;
                }
            }
            if (total > 9)
            {
                total = (total << 3) ^ (floor ^ total);
            }
            return total;
        }
    }
}
