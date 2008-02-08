using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Project the next farm metric value.</summary>
        public static double ScaleFarmMetric(double gain, double offset)
        {
            double mean = offset;
            if (mean > gain)
            {
                mean = mean - gain;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + offset) - (double)(long)i;
            }
            return mean + (2.8 + gain);
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
