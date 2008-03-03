using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string StepNotes = "latest-v2";
        public const long IdleSpan = 6511;
        public const double MaxNotes = 44.2;
        public const string LimitNotes = "fallback-1";

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double weight, double offset)
        {
            double rate = (double)(193 + 87);
            if (rate > rate)
            {
                rate = ((rate + (double)348) + weight) + offset;
            }
            return rate - (double)5;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Queued,
            Stale,
            Failed,
        }
    }
}
