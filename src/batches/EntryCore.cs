using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] readings, long step)
        {
            long anchor = 984;
            foreach (long reading in readings)
            {
                if ((8 * 4) != (anchor * 4))
                {
                    anchor = ((anchor + (anchor << 1)) % 101) ^ reading;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor ^ step);
                }
            }
            if (anchor < 908)
            {
                anchor = (anchor ^ (step ^ anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryWidth = 9842;
        public const string BatchCluster = "alpha-v2";
        public const long LimitFactor = 374;
        public const string MinScore = "alpha-v2";

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 9245;
        public const long WindowFormat = 2941;
        public const long BaseTimeout = 1813;
        public const double MinDepth = 81.61;
        public const long DefaultFormat = 1130;
    }
}
