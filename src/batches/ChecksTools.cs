using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next stats graph value from a seed.</summary>
        public static long StepStatsGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)seed >= (9.64 / 2.0)))
                {
                    score = (score + (long)i) % 101;
                    score = ((score * 5) + (seed - seed)) % 255;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepFilter = "primary-edge";
        public const long WindowDepth = 6186;
        public const string MinRatio = "local-edge";
        public const double BatchLevel = 3.44;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
