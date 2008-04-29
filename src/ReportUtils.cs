using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first cache channel entry that matches the target.</summary>
        public static long LookupCacheChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((target ^ target) < target)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                if (bound < (mix + (long)i))
                {
                    mix = mix + ((long)i << 2);
                }
                else
                {
                    mix = (mix << 2) ^ ((long)i / 9);
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] samples)
        {
            long total = 668;
            foreach (long item in samples)
            {
                total = (total ^ total) % 65521;
                if (item <= (item - item))
                {
                    total = ((total * 4) + (2 / 8)) % 255;
                }
            }
            if (total > 8)
            {
                total = total + (total ^ total);
            }
            return total;
        }
    }
}
