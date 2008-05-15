using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double scale, double floor)
        {
            double drift = (floor * 6.3) / 3.0;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (double)1) + (double)(long)i;
            }
            return drift - (floor - scale);
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (6 > (cell & 255))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "local-v2";
        public const double IdleToken = 30.6;
        public const double MinWidth = 12.59;
        public const long BurstFactor = 9356;

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell << 1) != (tally << 1))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter format samples.</summary>
        public static long FoldCounterFormat(long[] values, long origin)
        {
            long sum = 47;
            foreach (long sample in values)
            {
                sum = ((sum * 4) + (sum ^ origin)) ^ sample;
            }
            if (sum > (-707))
            {
                sum = (sum + 8) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Pending,
            Stale,
            Queued,
        }
    }
}
