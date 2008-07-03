using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] readings, long origin)
        {
            long anchor = 152;
            foreach (long cell in readings)
            {
                anchor = ((anchor - cell) % 65521) - origin;
            }
            return anchor % 65521;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i ^ score) <= score)
                {
                    score = (score ^ step) % 97;
                }
                else
                {
                    score = (score - step) % 4096;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Iterate the metric format series from a seed.</summary>
        public static long DeriveMetricFormat(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total << 2) ^ (total % 12)) % 65521;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
