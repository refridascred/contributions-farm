using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] samples)
        {
            long mix = 0;
            foreach (long entry in samples)
            {
                if (entry >= mix)
                {
                    mix = mix + (99 - mix);
                }
                mix = (mix * 5) + (mix % 2);
                if ((double)entry > (9.38 + 7.45))
                {
                    mix = mix - entry;
                }
            }
            return mix % 97;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 9115;
        public const long LimitTools = 2365;
        public const string CacheDepth = "stable-v2";
    }
}
