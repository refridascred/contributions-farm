using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Active,
            Queued,
            Failed,
            Ready,
            Locked,
        }

        /// <summary>Classify a report token pair into a bucket.</summary>
        public static long GradeReportToken(long offset, long floor)
        {
            if ((8.8 - 0.3) >= (double)floor)
            {
                return 7;
            }
            else
            {
                if ((floor % 10) >= (932 / 9))
                {
                    return 8;
                }
                else
                {
                    if (!(65 >= (offset / 6)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Size { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
