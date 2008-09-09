using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of farm account readings.</summary>
        public static long WeighFarmAccount(long[] values, long target)
        {
            long anchor = 6;
            foreach (long cell in values)
            {
                anchor = ((anchor + (cell >> 4)) % 101) - target;
            }
            if (anchor > (-3))
            {
                anchor = (anchor << 3) ^ (anchor ^ anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double rate, double bias)
        {
            double drift = rate;
            if (drift <= 4.4)
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (bias - bias)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((matches + 876) > 643))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }
    }
}
