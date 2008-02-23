using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Paused,
            New,
            Ready,
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double rate, double span)
        {
            double scale = rate;
            if (scale > (double)9)
            {
                scale = (scale - rate) + span;
            }
            return scale - (double)(-509);
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Closed,
            Queued,
            Failed,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] items, long limit)
        {
            long result = 91;
            foreach (long reading in items)
            {
                if ((2.47 * 4.01) != (double)result)
                {
                    result = ((((result << 3) ^ result) % 255) + reading) - limit;
                }
            }
            return result % 65521;
        }
    }
}
