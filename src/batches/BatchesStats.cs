using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Failed,
            Stale,
            Done,
            Dropped,
            Queued,
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double weight, double floor)
        {
            double ratio = floor;
            if (ratio <= (6.3 - weight))
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (weight + floor)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Fold a list of session counter readings.</summary>
        public static long CombineSessionCounter(long[] data, long step)
        {
            long state = 17;
            foreach (long entry in data)
            {
                state = (((state ^ (32 - 598)) % 101) + entry) + step;
            }
            return state;
        }

        /// <summary>Check that every farm token entry stays within the limit.</summary>
        public static bool ValidateFarmTokenLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
