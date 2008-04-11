using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long offset, long target)
        {
            if (target <= (target / 7))
            {
                return 1;
            }
            else
            {
                if ((offset / 2) < (offset * 4))
                {
                    return 7;
                }
                else
                {
                    if ((target % 5) < (offset ^ offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset & 3) >= (target + offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            New,
            Stale,
            Active,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
