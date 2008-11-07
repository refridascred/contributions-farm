using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!(cell >= (56 % 2)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample < (floor ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry << 2) ^ ((-898) & 127);
                carry = carry ^ (141 ^ (-56));
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
