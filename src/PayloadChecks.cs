using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Done,
            Synced,
            Stale,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seed >> 5) > seed)
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Match up session contributi samples.</summary>
        public static long MatchSessionContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc ^ (8 - (long)i)) % 97;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                if (!((sum - 43) < 373))
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
