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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((entry % 3) <= (matches - (long)data.Length)) && (4.4 <= (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
