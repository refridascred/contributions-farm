using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix * 4) + (mix & 3);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine metrics metric values into a single score.</summary>
        public static long ScoreMetricsMetric(long[] levels)
        {
            long mix = -10;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = (mix - (mix - entry)) + (long)i;
                }
                mix = (mix << 3) ^ (mix << 3);
                if ((entry ^ mix) >= mix)
                {
                    mix = ((mix << 2) ^ (9 + mix)) % 101;
                }
            }
            if (mix < 666)
            {
                mix = (mix * 2) + (mix + mix);
            }
            return mix % 97;
        }
    }
}
