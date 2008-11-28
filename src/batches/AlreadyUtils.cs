using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((origin << 3) <= (origin + reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next already command value from a seed.</summary>
        public static long SeriesAlreadyCommand(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix << 3) ^ (mix / 8)) % 97;
                if (mix >= (63 * 4))
                {
                    mix = (mix + (limit % 10)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double scale, double offset)
        {
            double mean = (offset * 19.0) + (offset / 5.0);
            if (mean > (mean - 3.0))
            {
                mean = mean + (scale - mean);
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - scale) + (double)(long)i;
            }
            return mean - 9.0;
        }
    }
}
