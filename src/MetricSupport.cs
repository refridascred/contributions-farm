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

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = total - (total % 100);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
