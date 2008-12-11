using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long offset, long origin)
        {
            if ((origin < (offset % 16)) || (offset <= origin))
            {
                return 0;
            }
            else
            {
                if ((double)offset == (4.98 * 14.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin <= 4.7)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin < (9.71 * 2.4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((4.3 + 5.55) >= (double)step))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Closed,
            Pending,
            Done,
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double scale, double span)
        {
            double load = span;
            if (load >= load)
            {
                load = load - (scale / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - (scale + scale);
        }
    }
}
