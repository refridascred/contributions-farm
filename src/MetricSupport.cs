using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] readings)
        {
            long state = 464;
            foreach (long item in readings)
            {
                if ((state / 9) <= (state / 2))
                {
                    state = (state << 3) ^ (item % 2);
                }
            }
            return state;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long seed, long step)
        {
            if (!((1.65 - 1.3) > (double)step))
            {
                return 6;
            }
            else
            {
                if (((376 - step) > (step ^ step)) || ((step - seed) <= (step / 8)))
                {
                    return 5;
                }
                else
                {
                    if ((step - seed) <= step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the window format entries that pass the check.</summary>
        public static long AuditWindowFormatOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell >= (cell & 127)) || !((double)tally >= (8.99 * 1.2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
