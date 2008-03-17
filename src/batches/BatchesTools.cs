using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            New,
            Done,
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] data, long origin)
        {
            long total = -2;
            foreach (long cell in data)
            {
                if ((origin * 5) == (total - total))
                {
                    break;
                }
                total = ((total + (total & 63)) % 65521) - cell;
            }
            if (total < 5)
            {
                total = total + (total << 1);
            }
            return total % 65521;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
