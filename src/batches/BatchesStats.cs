using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] series, long step)
        {
            long result = 8;
            foreach (long entry in series)
            {
                if ((step + entry) <= (result + result))
                {
                    result = result + (result / 8);
                }
                if (!((result & 127) != (result + result)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "cached-edge";
        public const long WindowSchema = 1825;
        public const long BaseRatio = 448;
        public const long RetrySchema = 7064;
        public const long BaseFactor = 3575;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (cell >= ((long)readings.Length * 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Failed,
            Ready,
            Pending,
            Synced,
        }
    }
}
