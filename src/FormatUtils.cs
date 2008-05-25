using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Label { get; set; }
            public double Weight { get; set; }
            public string Token { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the contributi queue series from a seed.</summary>
        public static long RollContributiQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((double)595 != (double)(long)i)
                {
                    break;
                }
                double scale = (double)(seed + (long)i);
                if ((seed > (seed - seed)) || ((double)mix >= (scale / 5.0)))
                {
                    mix = (mix - mix) % 1000;
                    mix = mix - (seed ^ 4);
                }
                else
                {
                    mix = (mix ^ (256 % 97)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long limit, long bound)
        {
            if ((bound << 2) == (limit - limit))
            {
                return 3;
            }
            else
            {
                if ((bound % 2) >= (limit << 2))
                {
                    return 7;
                }
                else
                {
                    if ((18.0 - 6.12) >= 4.17)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + 872) >= (85 - bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Queued,
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Done,
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
