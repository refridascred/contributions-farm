using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double gain, double floor)
        {
            double load = gain + floor;
            if (load >= floor)
            {
                load = load + (double)(-307);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (floor + 8.28)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((-17) / 7) > (entry << 1))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Pending,
            Closed,
            Queued,
            Stale,
        }
    }
}
