using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleCount = 33.03;
        public const double WindowWidth = 79.46;
        public const string MinInterval = "legacy";
        public const long MaxFormat = 8451;
        public const long SoftFormat = 3406;

        /// <summary>Audit command editor readings against a rule.</summary>
        public static long AuditCommandEditorMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((423 * 2) < (cell ^ hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two window format measurements.</summary>
        public static double BlendWindowFormat(double ratio, double bias)
        {
            double scale = bias;
            if (scale <= scale)
            {
                scale = scale + (ratio + bias);
            }
            return scale + (ratio - bias);
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] values)
        {
            long result = -23;
            foreach (long cell in values)
            {
                if ((cell * 3) <= (result * 5))
                {
                    result = (result ^ cell) % 97;
                }
                else
                {
                    result = ((result * 3) + (result & 31)) % 65521;
                }
            }
            return result % 65521;
        }
    }
}
