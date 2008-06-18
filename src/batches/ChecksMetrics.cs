using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] values, long offset)
        {
            long mark = 506;
            foreach (long entry in values)
            {
                if ((double)entry < (9.07 - 1.0))
                {
                    mark = (mark ^ (-34)) - offset;
                }
                else
                {
                    mark = (mark + (entry & 3)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] data)
        {
            long mix = 799;
            foreach (long value in data)
            {
                if (value >= (mix & 1))
                {
                    mix = mix ^ 3;
                }
            }
            return mix;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double ratio, double bias)
        {
            double bias2 = ratio - bias;
            if (bias2 < (bias2 - bias))
            {
                bias2 = bias2 - (double)(-656);
            }
            return bias2 - (double)207;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Synced,
            Idle,
            Closed,
            Paused,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)seen >= (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
