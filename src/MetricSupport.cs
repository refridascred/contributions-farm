using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every graph contributi entry stays within the limit.</summary>
        public static bool VerifyGraphContributiLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] readings)
        {
            long acc = -4;
            foreach (long item in readings)
            {
                acc = (acc << 2) ^ (acc & 127);
                if (((7.75 / 9.0) > (double)acc) && ((item % 97) < (acc * 3)))
                {
                    acc = acc ^ (acc / 3);
                }
                else
                {
                    acc = (acc - 5) % 101;
                }
                if ((2 + 480) >= (acc + 4))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }
    }
}
