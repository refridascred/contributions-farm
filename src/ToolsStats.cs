using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < ratio)
            {
                ratio = ratio - scale;
            }
            else
            {
                ratio = ratio + (ratio * 5.0);
            }
            return ratio + (8.8 + floor);
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Synced,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Done,
            Queued,
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double gain, double span)
        {
            double weight = span;
            if (weight < 6.3)
            {
                weight = (weight + (9.76 / 8.0)) + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (5.36 / 3.0)) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (10.0 > (double)datum)
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }
    }
}
