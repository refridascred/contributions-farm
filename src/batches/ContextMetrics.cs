using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate command metrics readings against a bound.</summary>
        public static bool VerifyCommandMetricsBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate format report samples.</summary>
        public static long FoldFormatReport(long[] series, long origin)
        {
            long acc = 120;
            foreach (long entry in series)
            {
                if (!((origin / 6) != (896 - 8)))
                {
                    acc = (acc + 84) % 97;
                    acc = acc ^ (entry ^ origin);
                }
                acc = (acc + (origin / 2)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 7936;
        public const long LimitFactor = 7773;
        public const string BaseCount = "open-v2";
        public const double HardRoute = 5.84;

        /// <summary>Look up the position of a profile account sample.</summary>
        public static long LocateProfileAccountIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            New,
            Idle,
            Active,
            Queued,
        }
    }
}
