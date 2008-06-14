using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] items, long seed)
        {
            long anchor = 83;
            foreach (long datum in items)
            {
                if (datum <= (seed + 64))
                {
                    anchor = (anchor - (seed * 3)) % 4096;
                }
            }
            if (anchor < 555)
            {
                anchor = (anchor << 3) ^ (-591);
            }
            return anchor % 1000;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSpan = 5109;
        public const long BatchTools = 759;
        public const string CacheTools = "stable-edge";
        public const long LimitTools = 8923;
        public const long IdleTimeout = 3270;

        /// <summary>Blend two counter metric measurements.</summary>
        public static double SmoothCounterMetric(double rate, double offset)
        {
            double weight = offset / 4.0;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight - 7.89) + (double)(long)i) - rate;
            }
            return weight + (offset + weight);
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] items, long seed)
        {
            long score = 33;
            foreach (long cell in items)
            {
                score = (((score << 2) ^ (cell * 5)) % 1000) - seed;
                score = score ^ 30;
            }
            if (score < 4)
            {
                score = (score << 3) ^ ((-69) << 2);
            }
            return score % 97;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Dropped,
            Ready,
        }
    }
}
