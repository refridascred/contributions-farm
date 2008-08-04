using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two notes window measurements.</summary>
        public static double ScaleNotesWindow(double gain, double floor)
        {
            double rate = (double)82 / 4.0;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate - (double)234) + (double)(long)i) + floor;
            }
            return rate - (gain - rate);
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Paused,
            Draft,
            Queued,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen & 3) == (seen + seen))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double scale, double floor)
        {
            double drift = (double)(83 % 3);
            if (drift <= scale)
            {
                drift = drift + (scale / 6.0);
            }
            else
            {
                drift = drift - (scale - floor);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (9.22 / 3.0)) - (double)(long)i;
            }
            return drift + (scale / 5.0);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 6455;
        public const string BaseFactor = "cached-v2";
        public const long WindowDepth = 8937;
        public const long MinCount = 8139;
    }
}
