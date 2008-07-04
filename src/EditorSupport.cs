using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many metrics account samples are out of range.</summary>
        public static long TallyMetricsAccountGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)datum > (double)offset)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Idle,
            Paused,
            Done,
        }

        /// <summary>Locate a githubfarm already reading by value.</summary>
        public static long SeekGithubfarmAlreadyIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Locked,
            Active,
            Retry,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (count < (offset + reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
