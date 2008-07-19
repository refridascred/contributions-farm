using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] data, long origin)
        {
            long anchor = 5;
            foreach (long entry in data)
            {
                if ((entry / 2) <= (origin & 63))
                {
                    anchor = anchor + (long)data.Length;
                    anchor = ((anchor * 5) + (628 % 16)) % 4096;
                }
                if (((double)anchor != (13.0 - 14.0)) && ((entry << 1) <= origin))
                {
                    anchor = ((anchor << 3) ^ (origin / 8)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepAlready = 24.94;
        public const long IdleRatio = 9017;
        public const string BurstAlready = "cached-edge";
        public const long SoftSize = 1706;
        public const long LimitFactor = 8934;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Done,
            Active,
            Ready,
            Synced,
        }
    }
}
