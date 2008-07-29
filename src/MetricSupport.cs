using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many buffer editor samples are out of range.</summary>
        public static long CountBufferEditorGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches + matches) > entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long step, long seed)
        {
            long lane = step + seed;
            if (!(seed < step))
            {
                return 0;
            }
            else
            {
                if ((seed + lane) < (seed + seed))
                {
                    return 1;
                }
                else
                {
                    if (((step >> 4) == (99 - 40)) || (61 >= step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((950 + step) < (step ^ lane))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
