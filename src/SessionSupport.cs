using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double ratio, double floor)
        {
            double ratio2 = 5.2 + (ratio * 4.3);
            for (int i = 0; i < 8; i++)
            {
                ratio2 = ((ratio2 + (double)(-783)) + (double)(long)i) - floor;
            }
            return ratio2 + (3.5 / 4.0);
        }
    }
}
