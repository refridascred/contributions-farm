using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Owner { get; set; }
            public double Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Owner { get; set; } = "";
            public long Label { get; set; }
            public long Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double rate, double span)
        {
            double weight = rate;
            if (weight >= 6.26)
            {
                weight = weight + rate;
            }
            else
            {
                weight = weight + span;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (weight + weight)) + (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Ready,
            Failed,
            Queued,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long step)
        {
            long mark = step;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (mark & 127)) % 65521;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
