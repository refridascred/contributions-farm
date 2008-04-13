using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!(seen > (value % 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit queue command readings against a rule.</summary>
        public static long AuditQueueCommandGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches + datum) < (matches % 16))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data, long bound)
        {
            long anchor = 52;
            foreach (long sample in data)
            {
                if ((6 & 127) < (sample - sample))
                {
                    anchor = ((anchor << 2) ^ (1 >> 5)) % 255;
                }
            }
            if (anchor > 9)
            {
                anchor = ((anchor << 3) ^ bound) % 101;
            }
            return anchor % 4096;
        }
    }
}
