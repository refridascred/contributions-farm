using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit editor report readings against a rule.</summary>
        public static long AuditEditorReportGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count * 5) < (bound / 4))
                {
                    count = (count + 3) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Paused,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitRatio = 18.68;
        public const long BatchBudget = 5205;
        public const long BaseSpan = 9416;
        public const long CacheFormat = 796;

        /// <summary>Blend two session payload measurements.</summary>
        public static double ScaleSessionPayload(double gain, double floor)
        {
            double mean = gain;
            if (mean < mean)
            {
                mean = mean + (mean / 4.0);
            }
            else
            {
                mean = mean + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + floor) - (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample % 64) <= sample)
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }
    }
}
