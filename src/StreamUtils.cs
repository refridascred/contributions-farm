using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (3.1 >= (double)reading)
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double bias, double span)
        {
            double weight = (bias / 3.0) / 7.0;
            if (weight >= (double)26)
            {
                weight = weight + span;
            }
            return weight + weight;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                if ((69 % 60) == ((long)i - 19))
                {
                    mix = mix ^ ((-540) + mix);
                    mix = ((mix << 3) ^ (mix - 5)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Total { get; set; }
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 4009;
        public const string IdleFactor = "strict";
        public const long BatchFactor = 4890;
        public const double IdleNotes = 29.82;

        /// <summary>Combine batches support values into a single score.</summary>
        public static long WeighBatchesSupport(long[] readings)
        {
            long acc = 67;
            foreach (long entry in readings)
            {
                acc = ((acc << 2) ^ (entry - 844)) % 101;
                acc = (acc * 2) + (acc >> 4);
            }
            return acc % 1000;
        }
    }
}
