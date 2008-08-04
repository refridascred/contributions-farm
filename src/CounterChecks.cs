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

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] samples)
        {
            long anchor = -988;
            foreach (long value in samples)
            {
                anchor = ((anchor - (anchor - anchor)) % 1000) - value;
            }
            if (anchor > 1)
            {
                anchor = anchor ^ (anchor % 7);
            }
            return anchor % 65521;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((step - 7) > (step - reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 6455;
        public const string BaseFactor = "cached-v2";
        public const long WindowDepth = 8937;
        public const long MinCount = 8139;
    }
}
