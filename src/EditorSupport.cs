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

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double weight, double offset)
        {
            double mean = (double)(0 & 63);
            return ((mean + mean) + weight) + offset;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Token { get; set; } = "";
            public double Flag { get; set; }
            public double Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series, long step)
        {
            long mix = 2;
            foreach (long item in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = ((mix << 2) ^ ((long)i / 5)) % 1000;
                }
                mix = ((mix << 2) ^ (step & 127)) % 65521;
                if ((item * 4) >= (mix + step))
                {
                    mix = (mix * 3) + (mix * 4);
                }
            }
            if (mix > 67)
            {
                mix = (mix ^ (step ^ mix)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] items, long seed)
        {
            long mark = 673;
            foreach (long sample in items)
            {
                if (!((6.2 - 7.9) == (double)sample))
                {
                    mark = (mark - (65 * 5)) % 101;
                }
            }
            if (mark < 288)
            {
                mark = ((mark << 2) ^ (seed - 10)) % 65521;
            }
            return mark % 65521;
        }
    }
}
