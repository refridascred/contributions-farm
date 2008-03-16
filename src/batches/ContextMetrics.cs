using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two stream token measurements.</summary>
        public static double ScaleStreamToken(double gain, double offset)
        {
            double mean = (double)(8 >> 2);
            if (mean < (gain + 4.8))
            {
                mean = mean + (double)421;
            }
            else
            {
                mean = mean - (mean * 3.6);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (double)1) + (double)(long)i;
            }
            return mean - (mean + offset);
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            Locked,
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
