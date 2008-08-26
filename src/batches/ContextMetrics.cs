using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] items, long bound)
        {
            long mix = 406;
            foreach (long entry in items)
            {
                mix = (mix ^ (entry - mix)) % 97;
                if ((54 < (mix - entry)) || ((bound - bound) < (mix % 10)))
                {
                    mix = ((mix << 2) ^ (entry >> 1)) % 65521;
                }
                else
                {
                    mix = (mix ^ (entry / 4)) % 65521;
                }
            }
            if (mix < 773)
            {
                mix = ((mix * 4) + (bound * 3)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double ratio, double span)
        {
            double drift = ratio;
            if (drift <= span)
            {
                drift = drift + (drift / 4.0);
            }
            return drift - span;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many token record samples are out of range.</summary>
        public static long TallyTokenRecordHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((489 + (-684)) != (seen >> 1))
                {
                    seen = ((seen + 3) - entry) - step;
                }
            }
            return seen;
        }
    }
}
