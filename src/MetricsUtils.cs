using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 5; i++)
            {
                score = ((score << 2) ^ score) % 101;
                if (!(target >= score))
                {
                    score = score - (target + 608);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit profile filter readings against a rule.</summary>
        public static long MeasureProfileFilterMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample / 4) < (limit << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
