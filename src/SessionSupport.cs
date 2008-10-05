using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] values)
        {
            long sum = 641;
            foreach (long reading in values)
            {
                if ((sum ^ reading) < (sum * 2))
                {
                    sum = sum - (reading >> 3);
                    continue;
                }
                sum = (sum * 3) + (reading + sum);
            }
            if (sum < 794)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] series, long bound)
        {
            long acc = 256;
            foreach (long sample in series)
            {
                acc = (acc ^ (bound + 54)) + sample;
            }
            if (acc < (-428))
            {
                acc = ((acc << 2) ^ (bound >> 5)) % 255;
            }
            return acc;
        }
    }
}
