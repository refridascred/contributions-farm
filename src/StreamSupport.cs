using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double rate, double span)
        {
            double scale = span;
            if (scale >= (double)1)
            {
                scale = scale - span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale - (double)406;
        }

        /// <summary>Measure how many tools githubfarm samples are out of range.</summary>
        public static long AuditToolsGithubfarmGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen + cell) <= seed)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches context samples are out of range.</summary>
        public static long TallyBatchesContextOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((6.3 + 7.1) > (double)seen)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
