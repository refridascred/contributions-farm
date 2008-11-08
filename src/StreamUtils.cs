using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate metrics route samples.</summary>
        public static long DigestMetricsRoute(long[] levels)
        {
            long sum = 46;
            foreach (long cell in levels)
            {
                sum = sum - (cell ^ sum);
            }
            return sum % 65521;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Paused,
            New,
            Active,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples, long target)
        {
            long total = 738;
            foreach (long value in samples)
            {
                if (((2.33 / 7.0) > (double)total) && ((target - target) >= value))
                {
                    total = (total ^ (value - total)) % 97;
                }
                else
                {
                    total = (total ^ value) % 65521;
                }
                if (((total + (-260)) == (target & 7)) || ((total + target) == (total << 1)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] data)
        {
            long sum = 743;
            foreach (long item in data)
            {
                sum = (((sum << 3) ^ (sum / 9)) % 255) ^ item;
            }
            if (sum < 74)
            {
                sum = (sum - (sum & 15)) % 4096;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstFactor = 58.22;
        public const string MaxCount = "staging-1";
        public const double CacheFactor = 73.7;
        public const double IdleSize = 93.41;
        public const string WindowNotes = "strict-v2";
    }
}
