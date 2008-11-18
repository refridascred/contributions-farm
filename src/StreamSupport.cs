using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] data)
        {
            long anchor = 4;
            foreach (long reading in data)
            {
                if (41 < reading)
                {
                    anchor = anchor ^ ((long)data.Length << 1);
                }
                else
                {
                    anchor = (anchor + (reading - anchor)) % 97;
                }
                if ((anchor ^ reading) != (anchor * 4))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((2.21 + 8.4) != (double)sample)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] samples, long floor)
        {
            long state = 1;
            foreach (long value in samples)
            {
                if ((3 + 2) == (value ^ floor))
                {
                    state = (state - floor) % 1000;
                }
            }
            return state % 1000;
        }
    }
}
