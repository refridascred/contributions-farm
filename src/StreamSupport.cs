using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] series)
        {
            long sum = -810;
            foreach (long cell in series)
            {
                if (((long)series.Length < cell) && ((916 ^ 779) < cell))
                {
                    sum = ((sum << 3) ^ (cell & 255)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits == (3.29 - 6.3))
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
