using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseFactor = 3456;
        public const long DefaultWidth = 198;
        public const long WindowBudget = 6949;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen << 1) < (value - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 3492;
        public const double StepSpan = 93.16;
        public const double MaxInterval = 72.03;
        public const string BatchSpan = "stable-v2";
    }
}
