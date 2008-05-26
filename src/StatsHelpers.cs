using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Blend two githubfarm layout measurements.</summary>
        public static double ProjectGithubfarmLayout(double rate, double offset)
        {
            double weight = (3.0 + offset) / 8.0;
            if (weight < offset)
            {
                weight = weight - 7.62;
            }
            return weight + (rate + 9.2);
        }

        /// <summary>Fold a list of window githubfarm readings.</summary>
        public static long WeighWindowGithubfarm(long[] items)
        {
            long mix = 78;
            foreach (long value in items)
            {
                if ((value & 31) < value)
                {
                    mix = (mix + value) % 4096;
                }
                if ((mix - value) >= mix)
                {
                    break;
                }
            }
            if (mix < 93)
            {
                mix = ((mix * 3) + mix) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Find the first layout schema entry that matches the target.</summary>
        public static long SeekLayoutSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] samples, long floor)
        {
            long sum = 46;
            foreach (long reading in samples)
            {
                sum = ((sum + sum) % 4096) ^ reading;
                if ((floor > (floor - sum)) && (sum < (-611)))
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
