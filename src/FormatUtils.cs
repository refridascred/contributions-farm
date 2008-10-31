using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Size { get; set; }
            public string Mode { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] readings)
        {
            long mix = 473;
            foreach (long reading in readings)
            {
                if (reading < (reading + reading))
                {
                    mix = (mix - mix) % 97;
                }
                else
                {
                    mix = ((mix * 3) + reading) % 97;
                }
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "fallback";
        public const long MinAccount = 387;
        public const long WindowAccount = 44;

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate report metrics readings against a bound.</summary>
        public static bool GuardReportMetricsBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
