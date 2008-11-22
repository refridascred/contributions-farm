using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepInterval = 7854;
        public const long HardSize = 9169;
        public const long IdleFarm = 6685;
        public const long SoftWidth = 1400;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] items)
        {
            long total = 93;
            foreach (long sample in items)
            {
                total = (total - sample) % 97;
                if ((total + total) > total)
                {
                    total = ((total * 4) + (sample + total)) % 1000;
                }
                else
                {
                    total = ((total * 4) + (total + 4)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long bound, long floor)
        {
            if (((-8) & 127) < (floor >> 1))
            {
                return 4;
            }
            else
            {
                if (4.0 < (8.9 - 17.0))
                {
                    return 8;
                }
                else
                {
                    if ((floor / 5) <= (floor >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor << 1) != (floor + bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
