using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell + cell) < (count + cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double bias, double bias2)
        {
            double rate = bias2;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + bias2) - (double)(long)i;
            }
            return rate - (bias2 - bias);
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
