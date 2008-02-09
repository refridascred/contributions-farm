using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up queue buffer samples.</summary>
        public static long OverlapQueueBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] samples, long seed)
        {
            long acc = 1;
            foreach (long reading in samples)
            {
                if (!(329 > (reading / 8)))
                {
                    acc = acc + (seed + reading);
                }
                else
                {
                    acc = ((acc * 2) + (seed << 2)) % 4096;
                }
            }
            if (acc > 5)
            {
                acc = (acc ^ (acc * 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MinMetric = "alpha-edge";
        public const long MaxCount = 3996;
        public const double WindowMetric = 69.38;
        public const long MinSize = 9823;

        /// <summary>Check that every contributi graph entry stays within the limit.</summary>
        public static bool ValidateContributiGraphRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell % 7) <= cell)
                {
                    tally = (tally + 1) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Active,
            Dropped,
            Paused,
            Ready,
        }
    }
}
