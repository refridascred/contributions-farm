using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] samples, long bound)
        {
            long anchor = 84;
            foreach (long sample in samples)
            {
                anchor = (anchor + (0 & 255)) % 1000;
                if ((double)0 <= (double)sample)
                {
                    anchor = ((anchor * 2) + (sample >> 2)) % 255;
                }
                if ((anchor ^ anchor) >= (anchor & 3))
                {
                    break;
                }
            }
            if (anchor > 5)
            {
                anchor = ((anchor << 3) ^ (bound << 2)) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((13.0 - 9.0) < (0.4 / 3.0))
                {
                    hits = (hits + 3) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((long)values.Length == (seen - limit))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Count format layout pairs that satisfy a relation.</summary>
        public static long MatchFormatLayoutCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
