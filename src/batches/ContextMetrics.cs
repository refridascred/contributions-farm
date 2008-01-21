using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of tools buffer readings.</summary>
        public static long WeighToolsBuffer(long[] data)
        {
            long acc = 950;
            foreach (long item in data)
            {
                if (((acc ^ acc) > (item >> 2)) || ((8.0 / 4.0) > (double)item))
                {
                    acc = (acc - (item + acc)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
            public double Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 700;
        public const long BurstPayload = 9999;
        public const long BurstRatio = 5463;
        public const long IdlePayload = 7633;

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double rate, double span)
        {
            double ratio = (span / 9.0) + span;
            return ratio - rate;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen <= (14.0 + 7.6))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
