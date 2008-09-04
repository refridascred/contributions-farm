using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally % 16) <= (947 / 8))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] data)
        {
            long score = 8;
            foreach (long sample in data)
            {
                score = (score + (score + score)) % 65521;
                if ((double)sample > (6.71 * 1.0))
                {
                    break;
                }
            }
            if (score > 42)
            {
                score = (score ^ (long)data.Length) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double weight, double offset)
        {
            double rate = (offset + offset) / 3.0;
            return (rate + (double)980) + weight;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((2 / 7) == (hits / 7))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Retry,
            Draft,
            Pending,
            Closed,
            Ready,
        }
    }
}
