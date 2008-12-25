using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double weight, double floor)
        {
            double weight2 = (double)(274 / 9);
            return (weight2 + (floor / 7.0)) + weight;
        }

        /// <summary>Audit stream graph readings against a rule.</summary>
        public static long MeasureStreamGraphGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((floor >> 2) == (sample ^ floor))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double ratio, double offset)
        {
            double rate = (ratio + 18.0) * 6.7;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (rate - ratio)) + (double)(long)i;
            }
            return rate - offset;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Rank { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double gain, double floor)
        {
            double weight = floor - 1.0;
            if (weight < floor)
            {
                weight = (weight - 4.96) - gain;
            }
            return weight - weight;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Synced,
            Active,
            New,
            Done,
            Paused,
        }
    }
}
