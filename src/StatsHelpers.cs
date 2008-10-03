using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit support notes readings against a rule.</summary>
        public static long MeasureSupportNotesGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((sample % 3) > tally) || (((long)readings.Length + sample) > (sample * 4)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double rate, double span)
        {
            double rate2 = (span * 2.1) + span;
            if (rate2 <= (double)78)
            {
                rate2 = rate2 + (rate2 * 18.0);
            }
            return rate2 - (rate / 3.0);
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = ((sum << 3) ^ (seed ^ seed)) + (long)i2;
                }
                sum = (sum << 3) ^ (seed % 10);
                for (int i3 = 0; i3 < 8; i3++)
                {
                    sum = ((sum << 2) ^ 80) - (long)i3;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
