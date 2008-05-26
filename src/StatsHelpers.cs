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

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
