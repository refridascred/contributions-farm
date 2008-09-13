using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long step, long origin)
        {
            if ((double)origin > (2.55 - 4.62))
            {
                return 7;
            }
            else
            {
                if (!(step < (origin % 3)))
                {
                    return 5;
                }
                else
                {
                    if ((step / 5) <= (step & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }
    }
}
