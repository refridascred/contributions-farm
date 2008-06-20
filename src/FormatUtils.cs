using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
            public double Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count metric window pairs that satisfy a relation.</summary>
        public static long MatchMetricWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the already window entries that pass the check.</summary>
        public static long AuditAlreadyWindowOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (entry < (entry % 16))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] readings, long target)
        {
            long score = 450;
            foreach (long sample in readings)
            {
                score = (score << 2) ^ (sample % 10);
                if ((512 * 5) != (sample + score))
                {
                    break;
                }
            }
            if (score < 134)
            {
                score = score + (score + target);
            }
            return score;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor * 2) + ((long)i - 210);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
