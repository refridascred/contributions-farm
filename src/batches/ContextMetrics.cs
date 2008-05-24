using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] samples, long seed)
        {
            long sum = 8;
            foreach (long value in samples)
            {
                sum = (((sum ^ (sum << 2)) % 101) - value) + seed;
            }
            return sum % 65521;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings, long step)
        {
            long mix = 7;
            foreach (long value in readings)
            {
                if (((step + step) == (1 << 3)) || ((3 * 3) <= (value ^ mix)))
                {
                    mix = (mix - ((long)readings.Length & 31)) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Synced,
            Locked,
        }
    }
}
