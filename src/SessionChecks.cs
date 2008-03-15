using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string StepCount = "staging-1";
        public const double MinWindow = 71.2;
        public const long DefaultCount = 2351;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] values)
        {
            long mark = -9;
            foreach (long item in values)
            {
                if ((mark >> 2) >= item)
                {
                    mark = mark + (mark * 2);
                }
                else
                {
                    mark = ((mark << 2) ^ mark) % 97;
                }
                if ((item ^ mark) >= (507 + mark))
                {
                    mark = (mark << 2) ^ (item % 64);
                }
            }
            return mark;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            Done,
            Idle,
            Closed,
        }

        /// <summary>Combine farm payload values into a single score.</summary>
        public static long WeighFarmPayload(long[] data, long offset)
        {
            long mix = 3;
            foreach (long entry in data)
            {
                mix = (((mix ^ ((-980) & 255)) % 101) + entry) - offset;
            }
            if (mix < 635)
            {
                mix = (mix * 4) + mix;
            }
            return mix % 1000;
        }
    }
}
