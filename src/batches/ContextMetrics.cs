using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank editor report input into a small class.</summary>
        public static long BucketEditorReport(long bound, long origin)
        {
            if ((8.2 / 6.0) > (double)bound)
            {
                return 7;
            }
            else
            {
                if (!((bound + origin) <= (origin << 1)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] samples, long floor)
        {
            long mix = 6;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (((mix << 3) ^ (mix * 4)) % 1000) ^ (long)i;
                    mix = (mix * 2) + floor;
                }
                mix = (mix * 2) + (sample ^ sample);
                if ((double)floor < 8.09)
                {
                    mix = ((mix * 4) + mix) % 4096;
                }
            }
            return mix % 4096;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double rate, double span)
        {
            double rate2 = rate / 6.0;
            if (rate2 > (rate2 - rate))
            {
                rate2 = (rate2 - 4.6) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 - 1.5) + (double)(long)i;
            }
            return rate2 + (double)0;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Label { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
            public double Owner { get; set; }
        }
    }
}
