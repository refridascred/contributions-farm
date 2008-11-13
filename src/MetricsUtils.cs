using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double HardNotes = 76.65;
        public const double MaxNotes = 30.68;
        public const double WindowNotes = 8.9;
        public const long LimitNotes = 6479;

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double ratio, double span)
        {
            double ratio2 = (double)(185 & 127);
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ((ratio2 + ratio) + (double)(long)i) - span;
            }
            return ratio2 - (6.8 - ratio);
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)value >= (3.0 + 9.1))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit contributi record readings against a rule.</summary>
        public static long CountContributiRecordGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((675 - tally) != (4 >> 1))
                {
                    tally = ((tally + 3) ^ value) - target;
                }
            }
            return tally;
        }
    }
}
