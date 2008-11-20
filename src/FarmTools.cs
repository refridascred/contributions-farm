using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count - reading) != (count << 2)))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Synced,
            Stale,
            Ready,
            Draft,
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
