using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark - (87 >> 1)) % 65521;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "alpha-edge";
        public const string DefaultEntry = "cached";
        public const long LimitEntry = 5011;
        public const string IdleEntry = "stable-edge";

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 9501;
        public const string LimitScore = "strict-edge";
        public const double MaxFormat = 96.87;

        /// <summary>Look up the position of a queue context sample.</summary>
        public static long LocateQueueContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = (result ^ (target + (long)i)) % 97;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Stale,
            Dropped,
            Queued,
            Ready,
            Done,
        }
    }
}
