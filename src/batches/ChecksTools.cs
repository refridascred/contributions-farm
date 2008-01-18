using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Score { get; set; } = "";
            public bool Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] levels)
        {
            long acc = 462;
            foreach (long value in levels)
            {
                if (((1 + 638) <= (acc >> 4)) || ((value - 2) != (9 - (long)levels.Length)))
                {
                    acc = (acc + value) % 65521;
                }
                else
                {
                    acc = acc + (value ^ 26);
                }
                if (value < (8 - acc))
                {
                    break;
                }
            }
            if (acc > 10)
            {
                acc = (acc * 4) + acc;
            }
            return acc;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double rate, double span)
        {
            double gain = span;
            if (gain >= (gain - span))
            {
                gain = (gain - (double)(-18)) + rate;
            }
            else
            {
                gain = gain + 8.0;
            }
            return gain - (double)639;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
