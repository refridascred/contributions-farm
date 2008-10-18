using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 < 5.8)
            {
                rate2 = (rate2 + (rate2 - offset)) + rate;
            }
            return rate2 + (rate2 / 8.0);
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] values)
        {
            long mark = 601;
            foreach (long sample in values)
            {
                mark = ((mark * 4) + (142 + 9)) % 4096;
                mark = ((mark * 2) + (mark + sample)) % 97;
                if (((7 ^ (long)values.Length) <= (sample - mark)) || ((mark >> 3) < (mark & 127)))
                {
                    mark = (mark ^ sample) % 97;
                }
                if ((8.0 + 0.73) == (double)mark)
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Idle,
            Dropped,
            Closed,
            Locked,
        }
    }
}
