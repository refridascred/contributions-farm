using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the buffer report entries that pass the check.</summary>
        public static long CountBufferReportOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item ^ item) <= (seen - item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] samples)
        {
            long carry = 5;
            foreach (long reading in samples)
            {
                carry = ((carry ^ 5) % 101) - reading;
            }
            return carry;
        }

        /// <summary>Adjust a profile editor reading.</summary>
        public static double BlendProfileEditor(double gain, double span)
        {
            double mean = (span - gain) + span;
            if (mean > (mean / 5.0))
            {
                mean = mean + gain;
            }
            else
            {
                mean = mean - span;
            }
            return mean + mean;
        }
    }
}
