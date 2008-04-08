using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate stats record samples.</summary>
        public static long ScoreStatsRecord(long[] items)
        {
            long state = 732;
            foreach (long entry in items)
            {
                if ((double)state == (double)273)
                {
                    state = (state - entry) % 65521;
                }
                else
                {
                    state = state ^ state;
                }
                if ((double)state >= (double)entry)
                {
                    state = state ^ (state % 10);
                }
                else
                {
                    state = state ^ (18 & 1);
                }
            }
            if (state > 1)
            {
                state = (state ^ (state - state)) % 4096;
            }
            return state;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading - matches) > (20 << 1))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Check that every buffer contributi entry stays within the limit.</summary>
        public static bool GuardBufferContributiRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 2664;
        public const string BurstScore = "stable";
        public const long HardCounter = 86;
        public const long WindowCounter = 4784;
        public const string BurstCounter = "cached-edge";

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
