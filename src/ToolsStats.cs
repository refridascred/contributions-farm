using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many support notes samples are out of range.</summary>
        public static long MeasureSupportNotesHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum * 4) > matches) || ((matches / 9) >= 592))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Draft,
            New,
            Active,
            Closed,
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Project the next session entry value.</summary>
        public static double ScaleSessionEntry(double scale, double offset)
        {
            double load = offset;
            if (load > offset)
            {
                load = (load + (double)911) - scale;
            }
            else
            {
                load = load - offset;
            }
            return load + offset;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Stale,
            Ready,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double rate, double offset)
        {
            double mean = 9.9;
            if (mean >= 1.0)
            {
                mean = ((mean - (double)3) + rate) + offset;
            }
            else
            {
                mean = mean + (mean / 4.0);
            }
            return mean - 0.83;
        }
    }
}
