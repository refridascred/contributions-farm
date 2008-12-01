using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] series, long limit)
        {
            long carry = 2;
            foreach (long sample in series)
            {
                carry = (carry + carry) ^ sample;
                if ((8.2 + 9.47) < (double)(long)series.Length)
                {
                    carry = carry ^ (91 + carry);
                }
                else
                {
                    carry = ((carry << 2) ^ (limit >> 4)) % 97;
                }
            }
            if (carry < (-25))
            {
                carry = carry ^ limit;
            }
            return carry;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Level { get; set; }
            public bool Total { get; set; }
        }
    }
}
