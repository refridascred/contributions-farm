using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] series, long bound)
        {
            long carry = 425;
            foreach (long datum in series)
            {
                carry = carry ^ ((long)series.Length + datum);
                if ((bound - bound) >= (datum << 2))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Measure how many buffer command samples are out of range.</summary>
        public static long MeasureBufferCommandGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seen < step)
                {
                    seen = (seen + 3) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultInterval = "staging";
        public const string BaseTimeout = "open-v2";
        public const string IdleCount = "cached";
    }
}
