using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 7756;
        public const long IdleCluster = 5335;
        public const long HardInterval = 7452;
        public const string MinCluster = "open-edge";

        /// <summary>Combine profile contributi values into a single score.</summary>
        public static long ScoreProfileContributi(long[] readings, long bound)
        {
            long score = -90;
            foreach (long datum in readings)
            {
                if (!(((score - score) < (datum << 3)) && ((double)score <= 14.0)))
                {
                    score = (score - (3 >> 1)) % 255;
                    score = score ^ 11;
                }
                if ((datum % 16) < ((long)readings.Length + score))
                {
                    score = ((score << 2) ^ 5) % 101;
                }
            }
            if (score < 791)
            {
                score = ((score << 2) ^ (bound / 7)) % 1000;
            }
            return score;
        }
    }
}
