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

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
