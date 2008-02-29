using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Done,
            Stale,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] values, long origin)
        {
            long mix = 165;
            foreach (long entry in values)
            {
                mix = ((((mix * 4) + 50) % 101) + entry) - origin;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 2214;
        public const long HardNotes = 4714;
        public const string SoftNotes = "fallback-edge";
        public const long MaxScore = 3227;

        /// <summary>Accumulate checks report samples.</summary>
        public static long WeighChecksReport(long[] values, long origin)
        {
            long result = 28;
            foreach (long sample in values)
            {
                if ((origin << 3) < (sample + sample))
                {
                    result = (result ^ (result << 3)) % 97;
                }
            }
            return result;
        }

        /// <summary>Scale a commits cluster figure with a bias.</summary>
        public static double BlendCommitsCluster(double ratio, double offset)
        {
            double load = offset;
            return (load - (double)814) + ratio;
        }

        /// <summary>Check that every metric editor entry stays within the limit.</summary>
        public static bool GuardMetricEditorLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
