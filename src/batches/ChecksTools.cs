using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Done,
            Ready,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series)
        {
            long total = 178;
            foreach (long reading in series)
            {
                if (!((1.5 + 6.4) < (double)reading))
                {
                    total = total + (total / 9);
                    total = ((total * 4) + (total / 4)) % 255;
                }
                total = total ^ (reading >> 2);
            }
            if (total < (-30))
            {
                total = (total + (total / 3)) % 4096;
            }
            return total;
        }
    }
}
