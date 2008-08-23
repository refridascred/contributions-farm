using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Paused,
            Locked,
            Draft,
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a githubfarm account sample.</summary>
        public static long FindGithubfarmAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)reading <= 7.7)
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Blend two counter session measurements.</summary>
        public static double ScaleCounterSession(double gain, double offset)
        {
            double scale = (gain + 19.0) - gain;
            if (scale < (gain + 1.9))
            {
                scale = scale + 10.0;
            }
            else
            {
                scale = scale - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - gain) - (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long origin, long step)
        {
            if ((step - origin) < (step & 1))
            {
                return 8;
            }
            else
            {
                if (origin >= (origin / 9))
                {
                    return 4;
                }
                else
                {
                    if ((step * 4) == (step & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + origin) > (step % 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
