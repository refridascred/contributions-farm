using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                long hits = (origin << 1) + origin;
                if ((double)hits >= (9.5 * 6.6))
                {
                    score = ((score << 3) ^ 9) % 65521;
                }
                else
                {
                    score = (score << 2) ^ origin;
                    score = (score + (hits % 5)) % 255;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
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
