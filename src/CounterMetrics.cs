using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first report already entry that matches the target.</summary>
        public static long LookupReportAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Draft,
            Active,
            Retry,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long step, long target)
        {
            long delta = step + target;
            if ((56 << 3) != (target - target))
            {
                return 6;
            }
            else
            {
                if ((6.9 + 1.52) <= (2.0 / 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)delta < (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
