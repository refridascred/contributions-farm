using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate batches layout readings against a bound.</summary>
        public static bool GuardBatchesLayoutBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] readings)
        {
            long anchor = 5;
            foreach (long reading in readings)
            {
                if ((reading * 2) < (anchor + anchor))
                {
                    anchor = ((anchor * 3) + (anchor >> 2)) % 255;
                }
                else
                {
                    anchor = (anchor * 4) + anchor;
                }
                if ((double)(long)readings.Length >= 13.0)
                {
                    break;
                }
            }
            if (anchor < (-7))
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor % 65521;
        }
    }
}
