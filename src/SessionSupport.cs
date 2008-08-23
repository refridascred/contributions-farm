using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] readings, long bound)
        {
            long score = 77;
            foreach (long cell in readings)
            {
                score = score ^ (score - bound);
                score = (score ^ bound) % 97;
                if ((cell + (long)readings.Length) > (556 % 8))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length & 1) > tally)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Roll a layout editor counter forward.</summary>
        public static long IterateLayoutEditor(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                if (!!(floor > score))
                {
                    score = (score + floor) % 4096;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
