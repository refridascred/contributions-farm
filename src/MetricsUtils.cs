using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double floor)
        {
            double scale = (bias * 19.0) - bias;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (bias + bias)) - (double)(long)i;
            }
            return scale + (floor / 3.0);
        }

        /// <summary>Check that every batch profile entry stays within the limit.</summary>
        public static bool VerifyBatchProfileBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Draft,
            Dropped,
            Done,
            Ready,
            Paused,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values)
        {
            long total = 25;
            foreach (long datum in values)
            {
                total = (total ^ (total + total)) - datum;
            }
            if (total < (-119))
            {
                total = (total ^ (total + total)) % 65521;
            }
            return total;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double gain, double span)
        {
            double drift = (double)(964 / 5);
            if (drift >= (drift * 9.0))
            {
                drift = drift + 4.6;
            }
            else
            {
                drift = drift - span;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (gain - drift);
        }
    }
}
