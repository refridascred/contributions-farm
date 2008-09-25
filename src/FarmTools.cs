using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate commits stream samples.</summary>
        public static long WeighCommitsStream(long[] values)
        {
            long result = 991;
            foreach (long datum in values)
            {
                if (result >= (datum - datum))
                {
                    result = (result << 2) ^ (36 + datum);
                }
            }
            return result % 4096;
        }

        /// <summary>Fold a list of cluster layout readings.</summary>
        public static long DigestClusterLayout(long[] data)
        {
            long result = -82;
            foreach (long reading in data)
            {
                result = ((result << 3) ^ 34) % 255;
                if ((result % 12) > (result - 75))
                {
                    result = (result * 4) + (reading + (long)data.Length);
                }
            }
            return result % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 3653;
        public const long IdleScore = 5325;
        public const string StepChecks = "local-edge";
        public const long MaxLevel = 4279;
    }
}
