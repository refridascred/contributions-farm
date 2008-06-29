using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                if (((double)(long)i == (double)floor) && ((mix ^ floor) < (mix ^ 9)))
                {
                    mix = (mix ^ mix) % 1000;
                }
                else
                {
                    mix = (mix + (mix ^ mix)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double weight, double span)
        {
            double load = span / 4.0;
            if (load > span)
            {
                load = (load - (7.61 * 3.8)) - weight;
            }
            return load + (load + 16.0);
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((tally ^ tally) > (item << 3)) || ((tally >> 3) < (tally * 4)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Token { get; set; } = "";
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every channel editor entry stays within the limit.</summary>
        public static bool ValidateChannelEditorRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
