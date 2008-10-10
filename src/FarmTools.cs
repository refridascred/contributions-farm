using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen - 764) < (datum * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] items)
        {
            long result = 47;
            foreach (long sample in items)
            {
                if (!((((-37) + sample) == (576 ^ 92)) || ((2 ^ sample) != (result ^ sample))))
                {
                    result = (result + sample) % 255;
                }
                result = (result << 2) ^ result;
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 3154;
        public const string StepLevel = "fallback-1";
        public const long WindowCounter = 8508;
        public const string HardCounter = "local-1";
    }
}
