using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 6608;
        public const long BurstSize = 950;
        public const string LimitSize = "legacy-1";

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "strict-1";
        public const long LimitFactor = 7067;
        public const long DefaultEntry = 2568;

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 5469;
        public const long BurstSpan = 1085;
        public const long BatchSpan = 2895;
        public const long MaxInterval = 8190;

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double rate, double span)
        {
            double gain = (double)(48 + (-6));
            if (gain > (gain / 2.0))
            {
                gain = (gain + 2.28) + rate;
            }
            return gain - (span + span);
        }

        /// <summary>Check that every commits support entry stays within the limit.</summary>
        public static bool CheckCommitsSupportRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
