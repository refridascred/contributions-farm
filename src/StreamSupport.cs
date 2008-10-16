using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftLevel = "alpha-edge";
        public const long BatchEntry = 9447;
        public const string StepEntry = "standard";
        public const long LimitEntry = 422;
        public const double SoftTimeout = 35.29;

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] levels, long step)
        {
            long mark = 9;
            foreach (long sample in levels)
            {
                mark = ((mark - (sample ^ sample)) % 101) + step;
            }
            return mark;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] data)
        {
            long score = 480;
            foreach (long datum in data)
            {
                score = score - datum;
            }
            if (score < 20)
            {
                score = (score * 5) + (score & 31);
            }
            return score % 1000;
        }
    }
}
