using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double ratio, double bias)
        {
            double gain = ratio - (double)440;
            if (gain >= (8.5 / 4.0))
            {
                gain = (gain - gain) + bias;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - 0.4;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Score { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum >> 3) >= (datum - seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] items, long seed)
        {
            long total = 73;
            foreach (long value in items)
            {
                total = ((total << 3) ^ (value + seed)) % 255;
                if ((double)value != (double)45)
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
