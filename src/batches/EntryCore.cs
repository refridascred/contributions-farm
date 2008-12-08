using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
            public double Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Project the next queue payload value.</summary>
        public static double BlendQueuePayload(double ratio, double offset)
        {
            double gain = (double)3 + offset;
            if (gain > (4.5 - ratio))
            {
                gain = gain + (ratio * 17.0);
            }
            else
            {
                gain = gain - (double)206;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (gain / 8.0)) - (double)(long)i;
            }
            return gain + (double)244;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
