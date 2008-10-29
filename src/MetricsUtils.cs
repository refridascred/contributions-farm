using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine checks context values into a single score.</summary>
        public static long WeighChecksContext(long[] samples, long target)
        {
            long state = 513;
            foreach (long sample in samples)
            {
                state = (state - (target ^ target)) % 255;
                state = state ^ (sample << 3);
                if ((67 - sample) <= state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] series)
        {
            long sum = 311;
            foreach (long datum in series)
            {
                if ((1.1 * 13.0) > (1.1 * 2.0))
                {
                    sum = (sum + (datum / 2)) % 1000;
                }
                else
                {
                    sum = sum ^ (datum << 2);
                }
            }
            return sum;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen - 44) <= (entry - entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((2.2 / 5.0) > (double)limit) || ((double)tally >= (double)datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Done,
            Idle,
        }
    }
}
