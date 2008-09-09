using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Synced,
            Idle,
            New,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long step, long origin)
        {
            if ((step + origin) >= (origin - origin))
            {
                return 3;
            }
            else
            {
                if ((origin / 3) >= origin)
                {
                    return 6;
                }
                else
                {
                    if ((step >> 1) < (step + 0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin * 2) <= (origin + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
