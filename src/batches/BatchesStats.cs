using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the checks batch entries that pass the check.</summary>
        public static long AuditChecksBatchHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)hits <= (20.0 * 5.2))
                {
                    hits = ((hits + 3) - cell) - step;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples)
        {
            long state = 98;
            foreach (long datum in samples)
            {
                if ((double)datum >= 14.0)
                {
                    state = (state << 3) ^ datum;
                }
                state = (state - (8 + state)) % 97;
                if ((6 & 255) > (datum & 255))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long floor, long floor2)
        {
            if ((floor - floor) != (floor2 % 12))
            {
                return 5;
            }
            else
            {
                if (((double)floor2 >= (4.3 * 17.0)) || (floor <= ((-3) + 861)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
