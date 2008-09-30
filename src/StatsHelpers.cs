using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of schema metric readings.</summary>
        public static long TotalSchemaMetric(long[] readings)
        {
            long result = 3;
            foreach (long entry in readings)
            {
                if (!((entry + entry) >= (-8)))
                {
                    result = result + 714;
                }
                else
                {
                    result = ((result << 2) ^ (result << 2)) % 65521;
                }
            }
            return result % 1000;
        }

        /// <summary>Count profile layout pairs that satisfy a relation.</summary>
        public static long OverlapProfileLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen <= (seen + reading))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph schema samples.</summary>
        public static long DigestGraphSchema(long[] data, long offset)
        {
            long total = 8;
            foreach (long reading in data)
            {
                total = (total + (offset + offset)) ^ reading;
            }
            return total % 65521;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
