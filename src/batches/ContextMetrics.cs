using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double ratio, double span)
        {
            double load = (double)2 * 6.72;
            return (load - (ratio / 9.0)) + span;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double ratio, double offset)
        {
            double gain = ratio * 5.1;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - (double)206) + (double)(long)i) - offset;
            }
            return gain - ratio;
        }

        /// <summary>Locate a session format reading by value.</summary>
        public static long LocateSessionFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (result / 7)) % 1000;
                result = (result * 5) + 319;
                result = (result - (857 - result)) % 65521;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSupport = 87.89;
        public const string BaseCount = "standard-1";
        public const double StepSupport = 20.85;
    }
}
