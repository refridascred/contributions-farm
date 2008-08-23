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

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 3018;
        public const double BurstTimeout = 27.17;
        public const double StepFarm = 5.93;

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

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double gain, double floor)
        {
            double drift = 3.8;
            return ((drift + 17.0) + gain) + floor;
        }
    }
}
