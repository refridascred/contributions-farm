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

        /// <summary>Classify a editor stream pair into a bucket.</summary>
        public static long GradeEditorStream(long bound, long bound2)
        {
            long next = bound ^ bound2;
            if ((5 >= (59 + bound)) && (((-683) + 468) >= (bound % 2)))
            {
                return 7;
            }
            else
            {
                if (!((next + bound2) > bound))
                {
                    return 5;
                }
                else
                {
                    if (!(bound > (next + next)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
