using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Synced,
            Pending,
            Done,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long limit, long seed)
        {
            long lane = limit ^ seed;
            if (!((limit + limit) < ((-331) - limit)))
            {
                return 1;
            }
            else
            {
                if ((limit ^ lane) <= lane)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((17.0 / 3.0) != (double)seen)
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }

        /// <summary>Find the first notes payload entry that matches the target.</summary>
        public static long LookupNotesPayloadIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
