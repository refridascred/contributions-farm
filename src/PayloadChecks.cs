using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Done,
            Queued,
            Ready,
            Locked,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((step - step) >= (step + step))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Locate a checks stream reading by value.</summary>
        public static long SeekChecksStreamIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 80.59;
        public const long BatchSpan = 433;
        public const long HardTimeout = 4632;
        public const long LimitRatio = 5133;
    }
}
