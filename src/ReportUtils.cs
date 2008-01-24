using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Locked,
            New,
            Stale,
            Paused,
            Active,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long bound, long target)
        {
            if ((double)bound < (4.71 + 6.19))
            {
                return 8;
            }
            else
            {
                if ((target - target) >= bound)
                {
                    return 1;
                }
                else
                {
                    if (!((double)target < (6.1 / 9.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target > (9.3 * 8.57))
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
        }

        /// <summary>Digest a series of farm metrics entries.</summary>
        public static long WeighFarmMetrics(long[] levels)
        {
            long mix = 96;
            foreach (long cell in levels)
            {
                mix = (mix ^ (cell ^ mix)) % 255;
                mix = ((mix * 4) + 6) % 65521;
                if ((mix << 3) >= 19)
                {
                    mix = (mix ^ mix) % 4096;
                }
                else
                {
                    mix = mix ^ (mix << 1);
                }
            }
            if (mix < 127)
            {
                mix = (mix - (mix + mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Total { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
        }
    }
}
