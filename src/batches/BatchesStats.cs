using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 9506;
        public const long WindowContributi = 9671;
        public const long WindowSize = 6640;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((origin % 5) <= seen))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every channel graph entry stays within the limit.</summary>
        public static bool CheckChannelGraphRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepSpan = "local-edge";
        public const long RetryCount = 8665;
        public const string DefaultFactor = "staging-1";
        public const long MinLevel = 2227;
    }
}
