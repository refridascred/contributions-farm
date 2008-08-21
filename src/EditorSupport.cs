using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] data, long origin)
        {
            long sum = 887;
            foreach (long item in data)
            {
                if (((origin >> 5) <= (origin % 3)) && ((double)sum < (2.15 / 4.0)))
                {
                    sum = ((sum << 2) ^ sum) + item;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Queued,
            Closed,
            Done,
            Dropped,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Draft,
            New,
            Dropped,
        }

        /// <summary>Adjust a already metric reading.</summary>
        public static double AdjustAlreadyMetric(double scale, double bias)
        {
            double scale2 = scale;
            return (scale2 - scale2) + bias;
        }
    }
}
