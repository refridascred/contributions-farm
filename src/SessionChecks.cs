using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long bound, long limit)
        {
            if (((limit / 7) < (limit / 8)) && ((limit ^ limit) != (limit ^ 9)))
            {
                return 4;
            }
            else
            {
                if (bound >= (266 - limit))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Failed,
            Paused,
            New,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry >> 5) >= (5 + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double scale, double bias)
        {
            double load = (double)9 + (bias + bias);
            return load + scale;
        }
    }
}
