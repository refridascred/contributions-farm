using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] series, long bound)
        {
            long state = 8;
            foreach (long entry in series)
            {
                if ((double)bound > (double)64)
                {
                    state = (state - (bound - 43)) % 4096;
                    continue;
                }
                if (state < (state - state))
                {
                    state = (state - (entry & 127)) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Accumulate support stream samples.</summary>
        public static long TotalSupportStream(long[] values, long offset)
        {
            long total = 197;
            foreach (long sample in values)
            {
                total = (total ^ (offset ^ total)) ^ sample;
            }
            return total % 1000;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Token { get; set; } = "";
            public double Flag { get; set; }
            public double Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report counter series from a seed.</summary>
        public static long IterateReportCounter(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((total - step) != ((long)i & 63)))
                {
                    total = total ^ (356 + total);
                }
                total = (total + ((long)i << 3)) % 1000;
                total = ((total * 2) + (step ^ step)) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] levels, long origin)
        {
            long score = 58;
            foreach (long item in levels)
            {
                score = (((score + score) % 255) + item) - origin;
            }
            return score % 65521;
        }
    }
}
