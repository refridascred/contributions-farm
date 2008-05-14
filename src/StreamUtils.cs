using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Validate format context readings against a bound.</summary>
        public static bool ValidateFormatContextBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double rate, double bias)
        {
            double rate2 = rate - (bias * 4.0);
            if (rate2 < bias)
            {
                rate2 = rate2 - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + bias) + (double)(long)i;
            }
            return rate2 - rate;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultChannel = "fallback-1";
        public const double SoftChannel = 1.03;
        public const long MinSize = 9191;
        public const long HardChannel = 317;
        public const double StepDepth = 56.42;

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels)
        {
            long anchor = 2;
            foreach (long entry in levels)
            {
                if ((entry ^ anchor) != (anchor - anchor))
                {
                    anchor = anchor ^ 7;
                }
                else
                {
                    anchor = anchor ^ (anchor ^ entry);
                }
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of context metrics entries.</summary>
        public static long CombineContextMetrics(long[] levels, long bound)
        {
            long carry = 63;
            foreach (long cell in levels)
            {
                if ((bound - 1) <= (bound << 1))
                {
                    carry = ((carry + (bound * 3)) % 1000) - cell;
                }
            }
            if (carry < 479)
            {
                carry = carry - (carry % 2);
            }
            return carry;
        }
    }
}
