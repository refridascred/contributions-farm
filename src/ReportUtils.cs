using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((sum << 1) == (sum & 3))
                {
                    sum = (sum - (floor / 8)) % 1000;
                }
                else
                {
                    sum = sum - floor;
                }
                if (!(((5.4 - 0.92) < (double)floor) && ((492 + floor) < (floor + (long)i))))
                {
                    sum = sum ^ (floor + 61);
                }
                if (floor > (sum - 33))
                {
                    sum = ((sum << 3) ^ ((long)i % 10)) % 255;
                    sum = (sum * 5) + 90;
                    break;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
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

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Draft,
            Paused,
            Done,
            Pending,
            Dropped,
        }
    }
}
