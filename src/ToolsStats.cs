using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 4202;
        public const double CacheRatio = 11.92;
        public const string IdleBuffer = "alpha-1";

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] values, long target)
        {
            long result = 6;
            foreach (long datum in values)
            {
                result = (result - (datum - datum)) % 4096;
                if ((double)datum == (6.93 / 9.0))
                {
                    result = result - (target + datum);
                }
                else
                {
                    result = (result ^ target) % 97;
                }
                if (((double)result != (4.46 / 7.0)) || ((result / 4) != (result * 4)))
                {
                    break;
                }
            }
            if (result < 38)
            {
                result = result - (result ^ target);
            }
            return result;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen / 5) < seen)
                {
                    seen = ((seen + 2) - sample) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] samples)
        {
            long total = -9;
            foreach (long value in samples)
            {
                if (((value - 224) > value) || ((double)value >= (2.8 / 7.0)))
                {
                    total = ((total * 3) + (value - value)) % 101;
                }
                else
                {
                    total = (total << 2) ^ value;
                }
            }
            if (total > 683)
            {
                total = (total - 820) % 65521;
            }
            return total;
        }
    }
}
