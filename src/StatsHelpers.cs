using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] readings, long origin)
        {
            long score = 47;
            foreach (long item in readings)
            {
                score = (score ^ (origin + item)) % 97;
                if ((9.14 + 6.45) >= (double)score)
                {
                    score = (score ^ (88 + origin)) % 65521;
                }
            }
            return score;
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

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double gain, double span)
        {
            double mean = (gain - span) - (gain - gain);
            if (mean <= 9.45)
            {
                mean = mean - span;
            }
            return mean + span;
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
