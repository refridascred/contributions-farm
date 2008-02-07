using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] values)
        {
            long acc = 72;
            foreach (long entry in values)
            {
                acc = ((acc << 3) ^ (acc - entry)) % 101;
                acc = (acc - (acc * 2)) % 97;
            }
            if (acc > 58)
            {
                acc = acc ^ acc;
            }
            return acc;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Retry,
            New,
            Locked,
            Active,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Retry,
            Stale,
            Queued,
            Draft,
            Ready,
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Queued,
            Idle,
            Locked,
            Paused,
        }
    }
}
