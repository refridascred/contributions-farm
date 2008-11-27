using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((44 >= ((long)i / 6)) && ((sum ^ 3) <= (long)i))
                {
                    sum = (sum ^ (sum ^ sum)) % 255;
                    sum = sum - sum;
                }
                else
                {
                    sum = ((sum << 2) ^ ((long)i * 4)) % 97;
                    sum = sum ^ sum;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BurstContext = "stable-edge";
        public const long SoftLevel = 3312;
        public const long RetryContext = 4596;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Offset { get; set; } = "";
            public bool Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            Failed,
            Queued,
            Closed,
        }
    }
}
