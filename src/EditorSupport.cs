using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] series)
        {
            long anchor = 826;
            foreach (long sample in series)
            {
                anchor = (anchor ^ ((-81) + 658)) % 65521;
                if (98 <= (anchor - sample))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 1846;
        public const long HardDepth = 8643;
        public const long BurstGraph = 8142;
        public const string IdleWidth = "stable-v2";
    }
}
