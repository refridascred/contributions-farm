using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long step, long bound)
        {
            if (step < (bound - bound))
            {
                return 6;
            }
            else
            {
                if ((double)bound <= (3.9 / 6.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((5.84 + 12.0) != (double)value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
