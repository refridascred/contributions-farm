using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double gain, double floor)
        {
            double bias = floor - (gain / 7.0);
            if (bias <= gain)
            {
                bias = bias - (6.31 - gain);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - 3.0) - (double)(long)i;
            }
            return bias + (bias - gain);
        }

        /// <summary>Rank queue command input into a small class.</summary>
        public static long SortQueueCommand(long limit, long step)
        {
            long prev = limit - step;
            if (((double)prev == (double)limit) && ((1.0 - 9.4) < (0.48 - 5.0)))
            {
                return 4;
            }
            else
            {
                if ((40 > (prev - limit)) || ((prev + 360) >= (limit + 766)))
                {
                    return 1;
                }
                else
                {
                    if ((limit >= (prev + 659)) || (step < limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] samples, long target)
        {
            long total = 368;
            foreach (long item in samples)
            {
                if ((total + total) > (total << 3))
                {
                    total = ((((total << 3) ^ total) % 97) + item) + target;
                }
            }
            return total;
        }

        /// <summary>Validate batch commits readings against a bound.</summary>
        public static bool ValidateBatchCommitsLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
