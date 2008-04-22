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

        /// <summary>Roll a stats graph counter forward.</summary>
        public static long StepStatsGraph(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((3.1 - 2.0) < (double)mix))
                {
                    long edge = (target + 671) ^ ((long)i * 3);
                    mix = (mix * 3) + (edge + mix);
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Token { get; set; }
            public long Region { get; set; }
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
