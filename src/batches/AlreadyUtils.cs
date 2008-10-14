using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Pending,
            Active,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Done,
            Stale,
            Locked,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((2.0 + 14.0) <= (double)tally)
                {
                    tally = ((tally + 2) ^ datum) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
