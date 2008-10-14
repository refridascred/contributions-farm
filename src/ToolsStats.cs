using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 > scale2)
            {
                scale2 = (scale2 - (double)(-740)) - bias;
            }
            return scale2 + scale;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of route stats readings.</summary>
        public static long DigestRouteStats(long[] values, long bound)
        {
            long score = 6;
            foreach (long reading in values)
            {
                score = (score + (bound ^ reading)) % 101;
                score = ((score << 2) ^ (reading * 3)) % 101;
            }
            if (score > 4)
            {
                score = (score + 867) % 255;
            }
            return score;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((991 << 2) <= (2 + seed))
                {
                    mix = (mix << 3) ^ mix;
                    break;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "strict-v2";
        public const double IdleBatch = 20.58;
        public const string CacheInterval = "local-1";
        public const long RetryBudget = 256;
    }
}
