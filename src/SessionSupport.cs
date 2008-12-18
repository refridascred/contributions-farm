using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long origin, long target)
        {
            long cur = origin + target;
            if ((origin ^ origin) == (target / 6))
            {
                return 8;
            }
            else
            {
                if (!((3.9 - 1.69) == (double)cur))
                {
                    return 6;
                }
                else
                {
                    if ((6.6 + 7.0) > (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target != (1.4 * 0.37))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((tally % 97) <= value) || (((tally ^ tally) >= (8 - value)) || (value < (value % 64))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Weight { get; set; }
            public double Ratio { get; set; }
        }
    }
}
