using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 2601;
        public const string BatchInterval = "cached-1";
        public const long BatchProfile = 4596;
        public const long MaxSize = 7374;
        public const long HardProfile = 901;

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double rate, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (16.0 + rate)) + (double)(long)i;
            }
            return weight + (weight - rate);
        }
    }
}
