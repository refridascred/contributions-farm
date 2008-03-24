using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] data, long step)
        {
            long result = -74;
            foreach (long entry in data)
            {
                if ((entry + result) < (390 * 5))
                {
                    result = (result + (785 << 1)) % 4096;
                }
                if (entry >= (step + step))
                {
                    result = (result * 4) + (776 + entry);
                }
                if ((entry + step) >= step)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long target, long target2)
        {
            if (((target - 4) == (5 - target2)) || (7.2 >= (double)target2))
            {
                return 4;
            }
            else
            {
                if ((target << 3) > (target2 << 1))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank githubfarm support input into a small class.</summary>
        public static long ClassifyGithubfarmSupport(long bound, long origin)
        {
            if ((double)bound != (2.4 / 3.0))
            {
                return 1;
            }
            else
            {
                if ((origin + bound) >= origin)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
