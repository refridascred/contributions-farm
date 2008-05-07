using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double ratio, double span)
        {
            double mean = span;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (ratio - span)) + (double)(long)i;
            }
            return mean + mean;
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

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
            public double Score { get; set; }
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
