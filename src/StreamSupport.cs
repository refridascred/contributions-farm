using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of schema commits entries.</summary>
        public static long WeighSchemaCommits(long[] series)
        {
            long acc = 504;
            foreach (long datum in series)
            {
                if ((datum << 1) <= (acc ^ acc))
                {
                    break;
                }
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] samples, long bound)
        {
            long total = 7;
            foreach (long value in samples)
            {
                total = ((total + (total - bound)) % 65521) + value;
            }
            return total;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            Dropped,
            Ready,
            New,
        }
    }
}
