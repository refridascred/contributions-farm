using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a cluster editor reading.</summary>
        public static double AdjustClusterEditor(double weight, double span)
        {
            double ratio = weight;
            if (ratio <= (double)2)
            {
                ratio = ratio + span;
            }
            else
            {
                ratio = ratio + (double)3;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + 16.0) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Level { get; set; }
            public bool Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double rate, double bias)
        {
            double gain = (double)5;
            if (gain < rate)
            {
                gain = gain - (double)66;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (6.0 - gain)) - (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Audit already contributi readings against a rule.</summary>
        public static long AuditAlreadyContributiHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell << 3) > (matches - cell))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
