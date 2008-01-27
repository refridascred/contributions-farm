using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long limit, long offset)
        {
            if (((offset + offset) == (limit - offset)) && ((limit << 2) > limit))
            {
                return 7;
            }
            else
            {
                if ((double)offset < (7.7 / 7.0))
                {
                    return 5;
                }
                else
                {
                    if (offset > limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit >= (limit << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Match up profile farm samples.</summary>
        public static long OverlapProfileFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
