using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long limit, long step)
        {
            if ((limit + 81) == (step % 16))
            {
                return 7;
            }
            else
            {
                if ((limit < (step ^ step)) && ((step - limit) >= (600 & 127)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Paused,
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
