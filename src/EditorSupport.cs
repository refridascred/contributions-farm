using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double scale, double floor)
        {
            double ratio = floor * 4.0;
            if (ratio >= floor)
            {
                ratio = ratio - scale;
            }
            else
            {
                ratio = ratio - (scale / 7.0);
            }
            return ratio + (double)789;
        }

        /// <summary>Match up route schema samples.</summary>
        public static long MatchRouteSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Retry,
            Closed,
            Ready,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Stale,
            Active,
            Failed,
            Paused,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowDepth = 14.35;
        public const string SoftCounter = "alpha-edge";
        public const string IdleCounter = "primary-v2";
        public const long WindowSize = 2084;
        public const long HardCounter = 907;
    }
}
