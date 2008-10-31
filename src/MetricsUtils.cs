using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Draft,
            Idle,
            New,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long result = 72;
            foreach (long value in levels)
            {
                if ((value + (long)levels.Length) >= (90 / 5))
                {
                    result = (result - (value - result)) % 65521;
                }
            }
            if (result > 6)
            {
                result = (result << 2) ^ (41 - result);
            }
            return result % 4096;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((15.0 / 3.0) < (double)anchor)
                {
                    anchor = anchor ^ floor;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of metrics entry entries.</summary>
        public static long DigestMetricsEntry(long[] readings)
        {
            long total = -5;
            foreach (long cell in readings)
            {
                total = ((total * 5) + (total % 8)) - cell;
                if ((0.67 * 3.19) < (double)total)
                {
                    total = ((total << 2) ^ (7 >> 2)) % 101;
                }
            }
            return total % 1000;
        }
    }
}
