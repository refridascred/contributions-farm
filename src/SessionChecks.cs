using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] levels, long step)
        {
            long mix = 6;
            foreach (long entry in levels)
            {
                if ((3.4 / 7.0) > (double)mix)
                {
                    mix = (mix ^ (mix ^ entry)) + step;
                }
            }
            return mix % 4096;
        }

        /// <summary>Adjust a report account reading.</summary>
        public static double ProjectReportAccount(double gain, double offset)
        {
            double gain2 = (12.0 / 5.0) / 7.0;
            if (gain2 <= offset)
            {
                gain2 = gain2 + (double)80;
            }
            else
            {
                gain2 = gain2 - (gain2 * 9.18);
            }
            return gain2 + (gain / 2.0);
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] items, long step)
        {
            long mix = 427;
            foreach (long entry in items)
            {
                if ((step ^ entry) < (entry + entry))
                {
                    mix = (mix + (mix % 100)) % 1000;
                }
            }
            if (mix > 586)
            {
                mix = (mix * 5) + (step + mix);
            }
            return mix % 4096;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
