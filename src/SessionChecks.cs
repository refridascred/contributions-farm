using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepWidth = 4251;
        public const long StepNotes = 6933;
        public const string MaxNotes = "standard-edge";
        public const string LimitRatio = "open-1";
        public const string RetryScore = "stable-v2";

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
