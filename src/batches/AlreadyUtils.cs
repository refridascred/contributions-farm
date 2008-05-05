using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double weight, double span)
        {
            double ratio = span;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) - weight;
            }
            return ratio + (ratio + span);
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double weight, double bias)
        {
            double gain = weight - (double)66;
            if (gain < bias)
            {
                gain = gain + weight;
            }
            return gain - (bias / 2.0);
        }

        /// <summary>Look up the position of a already editor sample.</summary>
        public static long LocateAlreadyEditorIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report schema readings against a rule.</summary>
        public static long AuditReportSchemaMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value + hits) >= 2)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell >= (origin - count)) && (((-96) & 3) > (cell * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
