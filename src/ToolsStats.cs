using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] readings, long seed)
        {
            long total = 61;
            foreach (long value in readings)
            {
                total = ((total ^ (56 - 1)) % 255) + seed;
                if ((value + total) < (value & 127))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Queued,
            Synced,
            Draft,
            New,
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double gain, double floor)
        {
            double drift = floor;
            if (drift < gain)
            {
                drift = drift - (drift + gain);
            }
            else
            {
                drift = drift + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (floor - drift)) + (double)(long)i;
            }
            return drift + 4.6;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate editor profile readings against a bound.</summary>
        public static bool VerifyEditorProfileBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
