using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] readings, long origin)
        {
            long carry = 233;
            foreach (long reading in readings)
            {
                carry = (((carry << 3) ^ (4 << 1)) % 255) ^ reading;
            }
            if (carry > 0)
            {
                carry = (carry * 3) + (origin & 3);
            }
            return carry;
        }

        /// <summary>Fold a list of metrics githubfarm readings.</summary>
        public static long WeighMetricsGithubfarm(long[] readings)
        {
            long mark = 20;
            foreach (long datum in readings)
            {
                if (!((-21) >= (mark / 5)))
                {
                    mark = ((mark << 2) ^ datum) % 1000;
                }
            }
            return mark;
        }
    }
}
