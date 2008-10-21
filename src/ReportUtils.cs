using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum >> 2) > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit support stream readings against a rule.</summary>
        public static long TallySupportStreamGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((((-985) ^ limit) < (141 >> 5)) && ((seen & 1) < (limit + limit)))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample - target) == (sample * 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
