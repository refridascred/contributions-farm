using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of record profile entries.</summary>
        public static long ScoreRecordProfile(long[] readings)
        {
            long acc = 57;
            foreach (long reading in readings)
            {
                acc = ((acc * 3) + acc) + reading;
            }
            return acc;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double gain, double span)
        {
            double load = span - (gain / 9.0);
            return load + 6.97;
        }
    }
}
