using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Closed,
            New,
            Paused,
            Ready,
        }

        /// <summary>Adjust a contributi report reading.</summary>
        public static double ProjectContributiReport(double ratio, double span)
        {
            double rate = (span * 9.5) / 5.0;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + (span * 9.48)) - (double)(long)i) - ratio;
            }
            return rate + rate;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Idle,
            New,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long floor, long offset)
        {
            long cur = floor - offset;
            if (floor > (offset >> 4))
            {
                return 4;
            }
            else
            {
                if ((floor - floor) == (floor % 12))
                {
                    return 7;
                }
                else
                {
                    if (!((double)offset < 18.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset > (cur - offset)) || ((double)cur != (9.4 * 1.76)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
