using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long offset, long bound)
        {
            if ((double)bound < (double)offset)
            {
                return 1;
            }
            else
            {
                if ((offset + bound) > offset)
                {
                    return 3;
                }
                else
                {
                    if ((bound < (-165)) || ((bound ^ offset) <= 84))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((bound + bound) != (bound * 2)) && (bound < (bound & 31)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Paused,
            Failed,
            Ready,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinLevel = 9786;
        public const long LimitNotes = 4372;
        public const string SoftNotes = "alpha-v2";
        public const double WindowSize = 88.25;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
