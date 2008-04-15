using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double bias, double offset)
        {
            double mean = bias;
            if (mean < (double)8)
            {
                mean = (mean - (double)(-78)) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (double)58;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Owner { get; set; } = "";
            public long Label { get; set; }
            public long Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] values)
        {
            long total = 86;
            foreach (long reading in values)
            {
                total = total - (total - reading);
                total = (total ^ (50 + 31)) % 65521;
            }
            return total;
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
