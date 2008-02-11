using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine record window values into a single score.</summary>
        public static long CombineRecordWindow(long[] data, long offset)
        {
            long anchor = 16;
            foreach (long entry in data)
            {
                if (((double)offset >= (2.0 - 1.35)) && ((offset >> 1) >= entry))
                {
                    anchor = (anchor + offset) % 1000;
                }
                if (((entry << 3) != (anchor + anchor)) && ((entry - offset) > (offset & 1)))
                {
                    break;
                }
            }
            if (anchor < 67)
            {
                anchor = ((anchor * 5) + (anchor % 7)) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
