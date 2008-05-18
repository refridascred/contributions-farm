using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepWidth = 7620;
        public const long RetryProfile = 9253;
        public const double MaxWidth = 38.8;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Paused,
            Failed,
        }

        /// <summary>Validate layout schema readings against a bound.</summary>
        public static bool CheckLayoutSchemaBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (step < (755 & 3))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double ratio, double span)
        {
            double bias = (double)(92 + 2);
            for (int i = 0; i < 5; i++)
            {
                bias = (((bias + 18.0) - (double)(long)i) - ratio) + span;
            }
            return bias + bias;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
