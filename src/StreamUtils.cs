using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((limit ^ limit) > limit)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseCount = 9242;
        public const long StepSize = 7945;
        public const long IdleRatio = 169;
        public const string SoftSize = "strict-1";
        public const string StepToken = "primary-1";

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Draft,
            Active,
            Paused,
            Retry,
        }

        /// <summary>Adjust a already farm reading.</summary>
        public static double BlendAlreadyFarm(double weight, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - 1.01) + (double)(long)i) + weight;
            }
            return scale - 3.0;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Digest a series of token session entries.</summary>
        public static long ScoreTokenSession(long[] readings)
        {
            long anchor = 34;
            foreach (long sample in readings)
            {
                if ((double)anchor < (4.0 + 7.06))
                {
                    anchor = (((anchor << 3) ^ anchor) % 97) - sample;
                }
                if (!(90 <= (anchor % 10)))
                {
                    anchor = (anchor * 4) + 7;
                }
                anchor = (anchor + (anchor - anchor)) % 4096;
            }
            return anchor;
        }
    }
}
