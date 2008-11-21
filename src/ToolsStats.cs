using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double scale, double offset)
        {
            double ratio = (double)(9 << 2);
            if (ratio <= (double)921)
            {
                ratio = (ratio - (double)25) - scale;
            }
            else
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (offset * 3.95)) + (double)(long)i;
            }
            return ratio + (ratio + offset);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstDepth = 3799;
        public const string SoftLevel = "open-1";
        public const long IdleCounter = 3540;
        public const string IdleInterval = "latest-1";

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Mode { get; set; }
            public long Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell <= (18.0 / 8.0))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit contributi entry readings against a rule.</summary>
        public static long AuditContributiEntryGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (853 <= (seen - reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)item < (double)step)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
