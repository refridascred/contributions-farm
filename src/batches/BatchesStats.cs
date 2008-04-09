using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Mode { get; set; }
            public bool Token { get; set; }
            public bool Flag { get; set; }
            public double Size { get; set; }
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

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
