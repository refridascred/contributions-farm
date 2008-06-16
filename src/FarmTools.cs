using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] readings, long offset)
        {
            long mark = 36;
            foreach (long reading in readings)
            {
                if (((reading + reading) > (reading << 3)) && ((reading * 5) == (reading % 97)))
                {
                    mark = (mark - 9) % 4096;
                }
                else
                {
                    mark = ((mark * 2) + (offset ^ reading)) % 1000;
                }
                if (((-255) + offset) == (offset + offset))
                {
                    mark = (mark - 7) % 255;
                }
                if (offset > (9 - reading))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
