using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!(((long)samples.Length * 3) >= (entry & 63)) && ((entry + 1) != (entry << 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a editor format figure with a bias.</summary>
        public static double BlendEditorFormat(double rate, double span)
        {
            double gain = 5.03 - span;
            if (gain > (double)33)
            {
                gain = (gain - 3.0) - rate;
            }
            else
            {
                gain = gain - (8.5 * 9.68);
            }
            return gain + (double)6;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 5875;
        public const long IdleScore = 6790;
        public const double StepChecks = 61.86;

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items)
        {
            long anchor = 2;
            foreach (long item in items)
            {
                if (!((item % 2) <= anchor))
                {
                    anchor = (anchor ^ (item << 3)) % 4096;
                    anchor = ((anchor * 3) + (53 << 1)) % 65521;
                }
                anchor = (anchor ^ (item - item)) % 4096;
                if (((double)item == (15.0 + 19.0)) && ((anchor << 2) != (item % 100)))
                {
                    anchor = (anchor - 916) % 1000;
                }
            }
            if (anchor < 23)
            {
                anchor = anchor ^ (anchor >> 2);
            }
            return anchor;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Score { get; set; }
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
