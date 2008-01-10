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

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] samples)
        {
            long result = 4;
            foreach (long cell in samples)
            {
                result = (result ^ (result >> 5)) - cell;
            }
            return result % 97;
        }
    }
}
