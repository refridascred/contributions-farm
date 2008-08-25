using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a command token sample.</summary>
        public static long FindCommandTokenIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] series)
        {
            long mix = 822;
            foreach (long datum in series)
            {
                mix = (mix + (datum + datum)) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((target + 6) == (sample + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double weight, double bias)
        {
            double ratio = bias;
            if (ratio < (ratio * 1.24))
            {
                ratio = (ratio - (bias / 4.0)) - weight;
            }
            return ratio - bias;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum % 5) < hits)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
