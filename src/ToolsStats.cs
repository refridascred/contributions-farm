using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                if ((double)target != (9.76 * 8.4))
                {
                    score = (score ^ target) % 4096;
                }
                if ((8.0 / 8.0) <= (double)target)
                {
                    score = (score << 2) ^ (score & 31);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long target, long origin)
        {
            long step = target - origin;
            if (!((185 >> 4) >= (step + target)))
            {
                return 6;
            }
            else
            {
                if (((origin - origin) >= (828 % 7)) || (origin <= (step % 24)))
                {
                    return 2;
                }
                else
                {
                    if (origin <= (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((step << 1) == (step + 76)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinSize = 7841;
        public const long StepBuffer = 854;
        public const long MaxTimeout = 7164;
    }
}
