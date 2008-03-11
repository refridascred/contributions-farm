using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            New,
            Draft,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstRatio = 1322;
        public const double IdleFactor = 20.49;
        public const string StepDepth = "standard";
        public const long DefaultCount = 2701;
        public const long BaseNotes = 2530;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Level { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleSpan = 2814;
        public const long MaxDepth = 3208;
        public const long MaxFactor = 9952;
    }
}
