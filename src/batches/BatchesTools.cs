using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] values)
        {
            long anchor = 4;
            foreach (long entry in values)
            {
                if (((long)values.Length / 9) != (entry << 3))
                {
                    anchor = (anchor * 2) + (68 >> 5);
                }
                else
                {
                    anchor = (anchor + (6 - entry)) % 255;
                    anchor = anchor ^ (38 / 7);
                }
                anchor = (anchor + entry) % 101;
                anchor = (anchor << 2) ^ entry;
            }
            return anchor % 65521;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
