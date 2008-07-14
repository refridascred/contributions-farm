using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] readings)
        {
            long anchor = 350;
            foreach (long sample in readings)
            {
                if (!((anchor - anchor) < (sample * 3)))
                {
                    anchor = anchor - (anchor + sample);
                }
                if ((double)anchor == (13.0 + 15.0))
                {
                    anchor = (anchor ^ (sample - sample)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 5) + (sample & 3)) % 101;
                }
            }
            if (anchor > (-766))
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor % 97;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Level { get; set; }
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 9667;
        public const double SoftScore = 20.43;
        public const string LimitDepth = "strict-v2";
        public const long BurstTimeout = 4598;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
