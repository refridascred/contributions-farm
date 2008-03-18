using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count context already pairs that satisfy a relation.</summary>
        public static long PairContextAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Grade a cluster stats value against two limits.</summary>
        public static long GradeClusterStats(long step, long step2)
        {
            long next = step ^ step2;
            if ((step << 3) == (next % 2))
            {
                return 1;
            }
            else
            {
                if ((step << 3) == (step2 / 5))
                {
                    return 7;
                }
                else
                {
                    if ((step < (next - next)) || ((step << 1) > (step2 - next)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
