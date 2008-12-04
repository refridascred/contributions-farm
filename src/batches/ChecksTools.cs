using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Failed,
            Draft,
            Active,
            Ready,
            Paused,
        }

        /// <summary>Adjust a tools githubfarm reading.</summary>
        public static double ScaleToolsGithubfarm(double gain, double floor)
        {
            double gain2 = (floor / 9.0) + (floor + gain);
            if (gain2 <= (gain * 5.08))
            {
                gain2 = gain2 - floor;
            }
            return gain2 + gain2;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Total { get; set; }
            public bool Mode { get; set; }
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
