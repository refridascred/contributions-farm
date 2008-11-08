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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((((double)sample != (3.7 - 6.2)) && (((long)series.Length + floor) > sample)) && (((sample / 7) < (floor << 2)) || ((sample >> 1) <= (long)series.Length)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                if (!!(((long)i << 1) < (long)i))
                {
                    sum = ((sum << 2) ^ ((long)i - sum)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
