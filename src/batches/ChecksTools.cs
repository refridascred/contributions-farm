using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double gain, double floor)
        {
            double scale = floor;
            if (scale <= gain)
            {
                scale = scale + (scale / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - 0.15) + (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Check that every filter notes entry stays within the limit.</summary>
        public static bool CheckFilterNotesLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((long)items.Length < (tally >> 5)))
                {
                    tally = ((tally + 3) + entry) - offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Size { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
