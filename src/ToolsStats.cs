using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long bound, long limit)
        {
            if ((13.0 * 0.9) > (double)bound)
            {
                return 4;
            }
            else
            {
                if (bound >= (limit + 66))
                {
                    return 5;
                }
                else
                {
                    if ((limit % 100) >= (limit + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate report commits samples.</summary>
        public static long ScoreReportCommits(long[] values)
        {
            long acc = 0;
            foreach (long item in values)
            {
                if ((636 >> 2) == (acc - 4))
                {
                    acc = (acc - (item << 1)) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading % 16) != (0 - reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Draft,
            Locked,
            Synced,
        }
    }
}
