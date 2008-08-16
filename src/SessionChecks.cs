using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] levels, long target)
        {
            long score = 2;
            foreach (long reading in levels)
            {
                if (((double)57 != (double)target) && ((78 + score) >= reading))
                {
                    score = (score ^ target) % 4096;
                }
                else
                {
                    score = (score ^ reading) % 255;
                }
            }
            if (score > 73)
            {
                score = (score * 3) + score;
            }
            return score;
        }

        /// <summary>Count command profile pairs that satisfy a relation.</summary>
        public static long MatchCommandProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the format filter entries that pass the check.</summary>
        public static long MeasureFormatFilterMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value + value) >= value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!(((double)seen < (9.0 - 6.0)) && (datum >= (datum - datum))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
