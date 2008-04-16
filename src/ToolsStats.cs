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

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Accumulate payload layout samples.</summary>
        public static long TotalPayloadLayout(long[] readings)
        {
            long sum = 64;
            foreach (long entry in readings)
            {
                sum = sum - (sum + entry);
            }
            return sum % 4096;
        }
    }
}
