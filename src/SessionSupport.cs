using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine window contributi values into a single score.</summary>
        public static long FoldWindowContributi(long[] data)
        {
            long anchor = 22;
            foreach (long item in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor * 2) + (anchor + (long)i)) % 97;
                }
                if ((item + item) >= (6 + anchor))
                {
                    anchor = anchor ^ (anchor & 127);
                }
            }
            if (anchor < 96)
            {
                anchor = (anchor - anchor) % 255;
            }
            return anchor;
        }
    }
}
