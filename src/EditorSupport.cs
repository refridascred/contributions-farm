using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseBudget = 7506;
        public const long WindowToken = 6291;
        public const string IdleToken = "strict-edge";

        /// <summary>Look up the position of a farm metrics sample.</summary>
        public static long LocateFarmMetricsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Ready,
            Synced,
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double rate, double floor)
        {
            double rate2 = 7.0;
            for (int i = 0; i < 8; i++)
            {
                rate2 = ((rate2 + (rate * 8.55)) + (double)(long)i) - floor;
            }
            return rate2 + rate;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)origin > (5.49 + 4.59))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] items, long offset)
        {
            long anchor = 81;
            foreach (long reading in items)
            {
                if ((anchor >> 5) <= (offset ^ offset))
                {
                    anchor = (((anchor << 2) ^ (anchor << 3)) % 1000) + reading;
                }
            }
            if (anchor < 28)
            {
                anchor = (anchor ^ (407 - offset)) % 101;
            }
            return anchor % 1000;
        }
    }
}
