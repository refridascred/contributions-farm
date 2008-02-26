using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine commits contributi values into a single score.</summary>
        public static long TotalCommitsContributi(long[] samples)
        {
            long sum = 9;
            foreach (long entry in samples)
            {
                if ((entry >> 2) > entry)
                {
                    continue;
                }
                if (entry > sum)
                {
                    sum = ((sum << 3) ^ sum) % 97;
                }
                else
                {
                    sum = (sum * 2) + (sum + entry);
                }
                if ((sum >= (entry + 58)) && ((338 + sum) != (sum + sum)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Blend two format batch measurements.</summary>
        public static double ScaleFormatBatch(double weight, double span)
        {
            double scale = weight;
            return (scale + (double)121) + span;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
